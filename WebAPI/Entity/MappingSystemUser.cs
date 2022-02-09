using AutoMapper;
using WebAPI.Model;

namespace WebAPI.Entity
{
    public class MappingSystemUser : Profile
    {
        public MappingSystemUser()
        {
            // must make sure the properties name are same between Employee, EmployeeEntity
            // otherwise you need to use .ForMember()
            CreateMap<SystemUser, SystemUserEntity>();
            /**
             
                .ForMember(
                dest => dest.EmergencyContact
                )
             */
            CreateMap<SystemRole, SystemRoleEntity>();
        }
    }
}
