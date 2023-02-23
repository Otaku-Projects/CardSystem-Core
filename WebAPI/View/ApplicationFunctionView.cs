using System;

namespace WebAPI.View
{
    public class ApplicationFunctionView
    {
        public int Id { get; set; }
        public ApplicationFunctionGroupView FunctionGroup { get; set; }
        public ApplicationSystemView Application { get; set; }
        public string Title { get; set; }
        public string IconCSS { get; set; }
        public string IconName { get; set; }
        public string Path { get; set; }
        public bool isShowInMenu { get; set; }
        public bool IsActive { get; set; }
    }
}
