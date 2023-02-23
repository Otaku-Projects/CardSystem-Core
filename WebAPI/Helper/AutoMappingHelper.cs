using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System;
using WebAPI.Model;
using WebAPI.View;
using WebAPI.Model.Auth;

namespace WebAPI.Helper
{
    public interface IAutoMappingHelper
    {
        Mapper Mapper { get; set; }
    }
    public class AutoMappingHelper : IAutoMappingHelper
    {
        public Mapper Mapper { get; set; }

        public AutoMappingHelper()
        {
            ConfigMapper();
        }

        private void ConfigMapper()
        {
            var configuration = new MapperConfiguration(config =>
            {
                //USER
                //config.CreateMap<SystemUser, UserView>()
                //    .ForMember(dest => dest.Enable2FA, opt => opt.MapFrom(src => src.TwoFactorEnabled))
                //    .ForMember(dest => dest.OfficeId, opt => opt.MapFrom(src => src.FactoryId))
                //    .ForMember(dest => dest.RegionCode, opt => opt.MapFrom(src => src.UserRegions.Select(p => p.Region.Code)));


                //APPLICATION
                config.CreateMap<ApplicationSystem, ApplicationSystemView>();

                //FUNCTION
                config.CreateMap<ApplicationFunction, RouteInfo>()
                    .ForMember(dest => dest.Class, opt => opt.MapFrom(src => string.Empty))
                    .ForMember(dest => dest.submenu, opt => opt.MapFrom(src => new List<RouteInfo>()));

                config.CreateMap<ApplicationFunctionGroup, RouteInfo>()
                    .ForMember(dest => dest.title, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.extralink, opt => opt.MapFrom(src => src.IsDisable))
                    .ForMember(dest => dest.submenu, opt => opt.MapFrom(src => new List<RouteInfo>()))
                    .ForMember(dest => dest.path, opt => opt.MapFrom(src => string.Empty))
                    .ForMember(dest => dest.Class, opt => opt.MapFrom(src => "has-arrow"));

                config.CreateMap<ApplicationFunction, ApplicationFunctionView>();



            });

            Mapper = new Mapper(configuration);
        }
    }
}