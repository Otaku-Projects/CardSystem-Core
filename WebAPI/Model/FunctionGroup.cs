using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class FunctionGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool IsDisable { get; set; }

        public List<ApplicationFunction> Function { get; set; }
    }
}
