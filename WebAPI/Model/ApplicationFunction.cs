using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class ApplicationFunction : BaseModel
    {
        public int Id { get; set; }
        public int? FunctionGroupId { get; set; }
        public int ApplicationId { get; set; }
        public string Title { get; set; }
        public string IconCSS { get; set; }
        public string IconName { get; set; }
        public string Path { get; set; }
        public bool IsVisible { get; set; } // visible = false, the route will not show on the web client mennu, but would allow the script navigate to it

        public List<SystemRole> RoleList { get; set; }
        public ApplicationFunctionGroup FunctionGroup { get; set; }
        public ApplicationSystem Application { get; set; }
    }
}
