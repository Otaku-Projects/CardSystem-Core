using System;
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
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
