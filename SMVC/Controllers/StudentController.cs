using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using SMVC.Models;
namespace SMVC.Controllers;
public class StudentController:Controller
{
    private readonly SmsDbContext context;
    public  StudentController(SmsDbContext _context)
    {
        context=_context;
    }
    public IActionResult List()
    {
        var data=context.Students.ToList();
        return View(data);
    }
    public IActionResult Display(int Id){

        var data = context.Students.Find(Id);
        return View(data);

    }
}

