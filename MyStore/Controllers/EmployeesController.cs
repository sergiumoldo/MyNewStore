using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Data;
using MyStore.Helpers;
using MyStore.Models;
using MyStore.MyStore.Services.Interfaces;
using MyStore.NewFolder;
using MyStore.Services;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {

            this.employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<EmployeeModel> Get(string? text, int pag = 1)
        {
           
            var pageSize = 2;

            var employees = employeeService.GetEmployees(pag, text);

            var modelsToReturn = new List<EmployeeModel>();
            foreach (var employee in employees)
            {
                modelsToReturn.Add(employee.ToEmployeeModel());
            }

            return modelsToReturn;
        }


        [HttpGet("{id}")]
        public ActionResult<EmployeeModel> GetById(int id)
        {

            var employee = employeeService.GetEmployee(id);

            if (employee == null)
            {
                return NotFound();
            }
            var model = new EmployeeModel();
            model = employee.ToEmployeeModel();

            return Ok(model);
        }


        [HttpPut("{id}")]
        public ActionResult<EmployeeModel> Update(int id, EmployeeModel model)
        {
            var existingEmployee = employeeService.GetEmployee(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            TryUpdateModelAsync(existingEmployee);

            var employeeToUpdate = new Employee();
            employeeToUpdate = model.ToEmployee();
            employeeService.Update(employeeToUpdate);

            return Ok(employeeToUpdate.ToEmployeeModel());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = employeeService.GetEmployee(id);

            if (employee == null)
            {
                return NotFound();
            }

            employeeService.Remove(employee);

            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(EmployeeModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //  business rules
            if (employeeService.IsDuplicate(model.Firstname))
            {
                ModelState.AddModelError("Categoryname", $"You can't have the duplicate items with the value {model.Firstname} on categoryName");
                return Conflict(ModelState);
            }

            var employeeToSave = new Employee();
            employeeToSave = model.ToEmployee();

            employeeService.InsertNew(employeeToSave);

            model.Firstname = employeeToSave.Firstname;

            return CreatedAtAction(nameof(GetById), new { id = employeeToSave.Firstname }, model);
        }
    }
}
