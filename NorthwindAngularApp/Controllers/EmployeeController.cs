using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_Backend.Back_End;
using Tarea_Backend.Models;

namespace NorthwindAngularApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeSC employeeService = new EmployeeSC();

        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            var employees = employeeService.GetEmployees().Select(s => new EmployeeDTO
            {
                id = s.EmployeeId,
                Nombre = s.FirstName,
                Apellido = s.LastName,
                Pais = s.Country,
                Ciudad = s.City,
                Direccion = s.Address,
                Nacimiento = s.BirthDate
            }).ToList();

            return Ok(employees);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var employee = employeeService.GetEmployeeById(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] EmployeeModel newEmployee)
        {
            try
            {
                employeeService.AddEmployee(newEmployee);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EmployeeModel newEmployee)
        {
            try
            {
                employeeService.UpdateEmployeeById(id, newEmployee);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                employeeService.DeleteEmployeeById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        #region helpers

        private IActionResult ThrowInternalErrorServer(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }

        #endregion

    }
}
