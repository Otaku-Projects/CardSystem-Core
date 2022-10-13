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
        public string Icon { get; set; }
        public string Path { get; set; }

        public List<SystemRole> RoleList { get; set; }
        public ApplicationFunctionGroup FunctionGroup { get; set; }
        public ApplicationSystem Application { get; set; }
    }
}
