using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class ApplicationFunctionGroup : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IconCSS { get; set; }
        public string IconName { get; set; }
        public bool IsDisable { get; set; }

        public List<ApplicationFunction> ApplicationFunctionList { get; set; }
    }
}
