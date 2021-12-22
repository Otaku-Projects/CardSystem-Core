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
    public class EmployeeEntityController : BaseController
    {
        private readonly IRepositoryWrapperEmployee _dataRepository;
        private IMapper _mapper;
        public EmployeeEntityController(IRepositoryWrapperEmployee dataRepository, IMapper mapper)
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
                var employees = _dataRepository.Employee.FindAll();

                var result = _mapper.Map<IEnumerable<EmployeeEntity>>(employees);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "");
            }
        }

        /*
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            try
            {
                var employees = _dataRepository.Employee.GetById(id);

                var result = _mapper.Map<EmployeeEntity>(employees);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "");
            }
        }
        */

        // GET api/values
        [HttpGet("{id}")]
        public IActionResult GetWithDetails(long employeeId)
        {
            //var domesticAccounts = _dataRepository.Employee.FindByCondition(x => x.EmployeeId.Equals("Domestic"));
            //var owners = _dataRepository.Employee.FindAll();
            //return new string[] { "value1", "value2" };
            try
            {
                var employee = _dataRepository.Employee.GetWithDetails(employeeId);
                if(employee == null)
                {
                    return NotFound();
                }
                else
                {
                    var result = _mapper.Map<EmployeeEntity>(employee);
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
