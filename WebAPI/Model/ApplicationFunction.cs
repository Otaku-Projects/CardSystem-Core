using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class ApplicationFunction
    {
        public int Id { get; set; }
        public int? FunctionGroupId { get; set; }
        public int ApplicationId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Path { get; set; }

        [JsonIgnore]
        public List<SystemRole> Roles { get; set; }
        [JsonIgnore]
        public FunctionGroup FunctionGroup { get; set; }
        public ApplicationSystem Application { get; set; }
    }
}
