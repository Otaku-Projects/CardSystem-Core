using AutoMapper;
using WebAPI.Model;

namespace WebAPI.Entity
{
    public class MappingEmployee : Profile
    {
        public MappingEmployee()
        {
            // muse make sure the properties name are same between Employee, EmployeeEntity
            // otherwise you need to use .ForMember()
            CreateMap<Employee, EmployeeEntity>();
            /**
             
                .ForMember(
                dest => dest.EmergencyContact
                )
             */

            CreateMap<EmployeeEmergencyContact, EmergencyContactEntity>();
        }
    }
}
