using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using SMVC.Models;
namespace SMVC.Controllers;
public class GradeController:Controller
{
    private readonly SmsDbContext context;
    public GradeController(SmsDbContext _context)
    {
        context=_context;
    }
    public IActionResult List()
    {
        var data=context.Grades.ToList();
        return View(data);
    }
    public IActionResult Create()
    {
        
        return View();
    }
    [HttpPost]
    public IActionResult Create(Grade gd)
    {
        if(ModelState.IsValid)
        {
        context.Grades.Add(gd);
        context.SaveChanges();
        return RedirectToAction("List");
        }
        return View();
    }
    public IActionResult Display(int Id){

        var data = context.Grades.Find(Id);
        return View(data);

    }
    

}