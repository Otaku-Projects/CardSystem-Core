using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Entity;
using WebAPI.Model;
using WebAPI.Model.Repository;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [AllowAnonymous]
    public class EmployeeEntityController : BaseController
    {
        private IUnitOfWork _unitOfWork;
        private readonly IRepositoryWrapperEmployee _dataRepository;
        private IMapper _mapper;
        public EmployeeEntityController(IUnitOfWork unitOfWork, IRepositoryWrapperEmployee dataRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _dataRepository = dataRepository;
            _mapper = mapper;
        }
        [HttpGet("Get")]
        public IActionResult Get()
        {
            try
            {
                var employees1 = _dataRepository.Employee.GenericGetAll().ToList();
                var employess2 = this._unitOfWork.EmployeeRepository.GenericGetAll().ToList();

                var result = _mapper.Map<IEnumerable<EmployeeEntity>>(employees1);
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
        [HttpGet("Get/{employeeId:long}")]
        public IActionResult GetWithDetails(long employeeId)
        {
            //var domesticAccounts = _dataRepository.Employee.FindByCondition(x => x.EmployeeId.Equals("Domestic"));
            //var owners = _dataRepository.Employee.FindAll();
            //return new string[] { "value1", "value2" };
            try
            {
                var employee1 = _dataRepository.Employee.GetWithDetails(employeeId);
                var employee2 = this._unitOfWork.RepositoryWrapperEmployee.Employee.GetWithDetails(employeeId);
                if (employee1 == null)
                {
                    return NotFound();
                }
                else
                {
                    var result = _mapper.Map<EmployeeEntity>(employee1);
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
