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

    

    public class DepartmentController : ControllerBase
    {
        private readonly SmartHRMContext _context;

        public class ParamQuery
        {
            public int? pageIndex { get; set; }
            public int? pageSize { get; set; }
            public string sortField { get; set; }
            public string sortOrder { get; set; }
            public string[] status{ get; set; }

        }

        public class DepartmentParameters
        {
            const int maxPageSize = 50;
            public int PageNumber { get; set; } = 1;
            private int _pageSize = 10;
            public int PageSize
            {
                get
                {
                    return _pageSize;
                }
                set
                {
                    _pageSize = (value > maxPageSize) ? maxPageSize : value;
                }
            }
        }

        public DepartmentController(SmartHRMContext context)
        {
            _context = context;
        }

        // GET: api/Department
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }

        // GET: api/Department
        [HttpGet]
        [Route("GetDepartmentsByFilter")]
        public  IEnumerable<Department> GetDepartmentsByFilter([FromQuery] ParamQuery query)
        {
            //return await _context.Departments.ToListAsync();
            return  this.GetDepts(query);
           
        }

        [HttpGet]
        [Route("GetDeptCount")]
        public int GetDeptCount()
        {
            var count = this.FindAll().ToList().Count;
            return count;
        }

        private IEnumerable<Department> GetDepts(ParamQuery deptParameters)
        {
            int pageIndex = Convert.ToInt32(deptParameters.pageIndex);
            int pageSize = Convert.ToInt32(deptParameters.pageSize);
            var sortField = deptParameters.sortField;
            var sortOrder = deptParameters.sortOrder;
            string sortFieldOrder = "";
            sortFieldOrder = sortField + "_" + "asc";

           

            if ( sortOrder == "descend")
            {
                sortFieldOrder = sortField + "_" + "desc";
            }

            var dept = this.FindAll()
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize);  

            if (deptParameters.status!=null)
            {
                dept = dept.Where(p => deptParameters.status.Contains(p.Status));
            }

            switch (sortFieldOrder)
            {

                case "code_desc":
                    dept = dept.OrderByDescending(s => s.Code);
                    break;
                case "description_asc":
                    dept = dept.OrderBy(s => s.Description);
                    break;
                case "description_desc":
                    dept = dept.OrderByDescending(s => s.Description);
                    break;
                default:
                    dept = dept.OrderBy(s => s.Code);
                    break;
            }
            return dept.ToList();
            
        }

        private IQueryable<Department> FindAll()
        {
            return this._context.Set<Department>();
        }

        // GET: api/Department/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            var department = await _context.Departments.FindAsync(id);

            if (department == null)
            {
                return NotFound();
            }

            return department;
        }

        // PUT: api/Department/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(int id, Department department)
        {
            if (id != department.DepartmentId)
            {
                return BadRequest();
            }

            _context.Entry(department).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
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

        // POST: api/Department
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartment(Department department)
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartment", new { id = department.DepartmentId }, department);
        }

        // DELETE: api/Department/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.DepartmentId == id);
        }


        [HttpPost]
        [Route("GetDepartmentCodeExists")]
        public async Task<IActionResult> GetDepartmentCodeExists([FromBody] Department model)
        {
            IActionResult response = Unauthorized();
            try
            {
                var dept = await (from d in _context.Departments
                                  where d.Code == model.Code
                                  select new Department
                                  {
                                      DepartmentId = d.DepartmentId,
                                      Code = d.Code,
                                      Description = d.Description,
                                      Status = d.Status
                                  }).FirstOrDefaultAsync();

                if (dept == null)
                {
                    response = Ok(new
                    {
                        Status = "NotExist",
                        Message = ""
                    });
                    return response;
                }
                else
                {
                    response = Ok(new
                    {
                        Status = "Exist",
                        Message = "Department code is already exists. Please try another one."
                    });
                    return response;
                }

                return Ok(dept);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
