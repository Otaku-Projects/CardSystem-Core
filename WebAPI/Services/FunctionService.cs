using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Helper;
using WebAPI.Model;
using WebAPI.Model.Auth;

namespace WebAPI.Services
{
    public interface IFunctionService
    {
        List<RouteInfo> GetRoutes(IList<string> roles, string applicationCode);
    }

    public class FunctionService : IFunctionService
    {
        private readonly RoleManager<SystemRole> roleManager;
        private readonly IAutoMappingHelper autoMappingHelper;

        public FunctionService(RoleManager<SystemRole> roleManager, IAutoMappingHelper autoMappingHelper)
        {
            this.roleManager = roleManager;
            this.autoMappingHelper = autoMappingHelper;
        }

        public List<RouteInfo> GetRoutes(IList<string> roles, string applicationCode)
        {
            List<RouteInfo> result = new();
            List<ApplicationFunction> functionList = new();

            var roleDetails = roleManager.Roles.Where(p => roles.Contains(p.Name))
                .Include(role => role.ApplicationFunctionsList)
                .ThenInclude(Functions => Functions.FunctionGroup)
                .Include(role => role.ApplicationFunctionsList)
                .ThenInclude(Functions => Functions.Application)
                .ToList();

            roleDetails.ForEach(p => functionList.AddRange(p.ApplicationFunctionsList));

            //Check Application
            functionList = functionList.Where(p => p.Application.Code == applicationCode && p.IsActive).ToList();

            //No Sub Menu
            var menu = functionList.Where(p => p.FunctionGroup == null).Distinct().ToList();
            result.AddRange(autoMappingHelper.Mapper.Map<List<RouteInfo>>(menu));

            //Group Route
            var groups = functionList.Where(p => p.FunctionGroup != null).Select(p => p.FunctionGroup).Distinct().ToList();

            //Sub Menu
            foreach (var group in groups)
            {
                var groupInfo = autoMappingHelper.Mapper.Map<RouteInfo>(group);
                var target = functionList.Where(p => p.FunctionGroup == group);

                groupInfo.submenu.AddRange(autoMappingHelper.Mapper.Map<List<RouteInfo>>(target));

                result.Add(groupInfo);
            }

            return result;
        }
    }
}
