using EMSApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace EMSApi.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController:ControllerBase
    {
        IDept repo;
        public DepartmentController(IDept _repo)
        {
            this.repo=_repo;
        }
        [HttpGet]
        [Route("ListDept")]
        public IActionResult GetDept()
        {
            var data=repo.GetDepartments();
            return Ok(data);
        }
        [HttpPost]
        [Route("Create")]
         public IActionResult PostDept(Department department)
        {
            if(ModelState.IsValid)
            {
                repo.AddDept(department);
                return Created("Record Added",department);

            }
            return BadRequest();
        }
    //     [HttpPost]
    //     [Route("Edit")]
    //      public IActionResult Put()
    //     {
            
    //     }
    //     [HttpDelete]
    //     [Route("Delete")]
    //      public IActionResult Delete()
    //     {
            
    //     }
    //      public IActionResult FindDept()
    //     {
            
    //     }

    }
}