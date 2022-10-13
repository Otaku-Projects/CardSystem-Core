using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class ApplicationSystem : BaseModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public List<SystemRole> RoleList { get; set; }
        public List<ApplicationFunction> FunctionList { get; set; }
    }
}
