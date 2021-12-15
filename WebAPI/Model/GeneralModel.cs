using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class GeneralModel
    {
        [Key]
        public virtual string Id { get; set; }
    }
}
