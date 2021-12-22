using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class Employee
    {
        [Key]
        public long EmployeeId { get; set; }

        //public override string Id
        //{
        //    get { return this.EmployeeId.ToString(); }
        //    set { this.EmployeeId = (long)Convert.ToDouble(value); }
        //}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<EmployeeEmergencyContact> EmergencyContactList { get; set; }
    }

    public enum Gender
    {
        [Description("Mela")]
        Mela = 11,

        [Description("Female")]
        Female = 12,

        [Description("Intersex")]
        Intersex = 13,

        [Description("Trans")]
        Trans = 14,

        [Description("Non-Conforming")]
        NotConformed = 15,

        [Description("Personal")]
        Personal = 16,

        [Description("Eunuch")]
        Eunuch = 17,
    }
}
