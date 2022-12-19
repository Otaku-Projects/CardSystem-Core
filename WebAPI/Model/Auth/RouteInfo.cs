using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model.Auth
{
    public class RouteInfo
    {
        [Required]
        public string path { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string icon { get; set; }
        [Required]
        public string iconCss { get; set; }
        [Required]
        public string iconName { get; set; }
        [Required]
        [Column("class")]
        public string Class { get; set; }
        [Required]
        public bool extralink { get; set; }
        [Required]
        public bool isShowInMenu { get; set; }
        [Required]
        public List<RouteInfo> submenu { get; set; }
    }
}
