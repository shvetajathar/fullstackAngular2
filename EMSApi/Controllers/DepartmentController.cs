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

    }
}