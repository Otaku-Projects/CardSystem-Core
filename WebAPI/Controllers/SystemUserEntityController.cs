using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAPI.Entity;
using WebAPI.Model;
using WebAPI.Model.Repository;

namespace WebAPI.Controllers
{
    [AllowAnonymous]
    public class SystemUserEntityController : BaseController
    {
        private readonly IRepositoryWrapperSystemUser _dataRepository;
        private IMapper _mapper;
        public SystemUserEntityController(IRepositoryWrapperSystemUser dataRepository, IMapper mapper)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            try
            {
                var users = _dataRepository.SystemUser.GenericGetAll();

                var result = _mapper.Map<IEnumerable<SystemUser>>(users);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "");
            }
        }

        // GET api/values
        [HttpGet("{id}")]
        public IActionResult GetWithDetails(string id)
        {
            try
            {
                var user = _dataRepository.SystemUser.GetWithDetails(id);
                if(user == null)
                {
                    return NotFound();
                }
                else
                {
                    var result = _mapper.Map<SystemUser>(user);     
                    return Ok(result);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, "");
            }
        }
    }
}
