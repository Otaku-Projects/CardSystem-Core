using System;
using System.Collections.Generic;
using WebAPI.Model;

namespace WebAPI.Entity
{
    public class EmergencyContactEntity
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        //public Employee Employee { get; set; }

        public string FullName { get; set; }
        public string Relationship { get; set; }
        public string Phone { get; set; }
    }
}
