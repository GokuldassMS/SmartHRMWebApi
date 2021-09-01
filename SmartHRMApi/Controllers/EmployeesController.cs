using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartHRMApi.Models;

namespace SmartHRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly SmartHRMContext _context;

        public class ParamQuery
        {
            public int? pageIndex { get; set; }
            public int? pageSize { get; set; }
            public string sortField { get; set; }
            public string sortOrder { get; set; }
            public string[] status { get; set; }
            public string[] gender { get; set; }

        }

        public EmployeesController(SmartHRMContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
             return await _context.Employees.ToListAsync();

            
        }

        // GET: api/Department
        [HttpGet]
        [Route("GetEmployeesByFilter")]
        public IEnumerable<Employees> GetEmployeesByFilter([FromQuery] ParamQuery query)
        {
            return this.GetEmps(query);

        }

        private IEnumerable<Employees> GetEmps(ParamQuery empParameters)
        {
            int pageIndex = Convert.ToInt32(empParameters.pageIndex);
            int pageSize = Convert.ToInt32(empParameters.pageSize);
            var sortField = empParameters.sortField;
            var sortOrder = empParameters.sortOrder;
            string sortFieldOrder = "";
            sortFieldOrder = sortField + "_" + "asc";



            if (sortOrder == "descend")
            {
                sortFieldOrder = sortField + "_" + "desc";
            }

            var emp = this.FindAllByFilter()
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize);

            if (empParameters.status != null)
            {
                emp = emp.Where(p => empParameters.status.Contains(p.Status));
            }

            if (empParameters.gender != null)
            {
                emp = emp.Where(p => empParameters.gender.Contains(p.Gender));
            }

            switch (sortFieldOrder)
            {

                case "employeeName_desc":
                    emp = emp.OrderByDescending(s => s.EmployeeName);
                    break;
                case "designation_asc":
                    emp = emp.OrderBy(s => s.Designation);
                    break;
                case "designation_desc":
                    emp = emp.OrderByDescending(s => s.Designation);
                    break;
                case "dob_asc":
                    emp = emp.OrderBy(s => s.Dob);
                    break;
                case "dob_desc":
                    emp = emp.OrderByDescending(s => s.Dob);
                    break;
                case "doj_asc":
                    emp = emp.OrderBy(s => s.Doj);
                    break;
                case "doj_desc":
                    emp = emp.OrderByDescending(s => s.Doj);
                    break;
                default:
                    emp = emp.OrderBy(s => s.EmployeeName);
                    break;
            }
            return emp.ToList();

        }

        [HttpGet]
        [Route("GetEmpCount")]
        public int GetEmpCount([FromQuery] ParamQuery empParameters)
        {
            var count=0;
            if (empParameters.status == null && empParameters.gender == null)
            {
                count = this.FindAll().ToList().Count;
            }
            else
            {
                var emp = this.FindAll();

                if (empParameters.status != null)
                {
                    emp = emp.Where(p => empParameters.status.Contains(p.Status));
                }

                if (empParameters.gender != null)
                {
                    emp = emp.Where(p => empParameters.gender.Contains(p.Gender));
                }

                count=emp.ToList().Count;
            }
                
            return count;
        }


        private IQueryable<Employee> FindAll()
        {
            return this._context.Set<Employee>();
        }

        private IEnumerable<Employees> FindAllByFilter()
        {
            return (from e in _context.Employees
                         from d in _context.Departments
                         where e.DepartmentId == d.DepartmentId
                         select new Employees
                         {
                             EmployeeId = e.EmployeeId,
                             EmployeeName = e.EmployeeName,
                             Status = e.Status,
                             Dob = e.Dob,
                             Doj = e.Doj,
                             Gender = e.Gender,
                             DepartmentId = e.DepartmentId,
                             DepartmentName = d.Description,
                             Designation = e.Designation,
                             Address1 = e.Address1,
                             Address2 = e.Address2,
                             ZipCode = e.ZipCode,
                             City = e.City,
                             State = e.State,
                             Email = e.Email
                         }).ToList();
        }


        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.EmployeeId }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
