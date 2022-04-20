using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class EmployeeEmergencyContact
    {
        [Key]
        public long Id { get; set; }

        // don't use [ForeignKey(nameof(Employee))]

        // foreignKey attribute overrides the default conventions
        // EF makes a property as foreign key property when its name matches with the primary key property of a related entity.
        // https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx

        // below would having default conventions from Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string FullName { get; set; }
        public string Relationship { get; set; }
        public string Phone { get; set; }
    }
}
