using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using EMS.Models;
namespace EMS.Controllers;
public class EmpController:Controller{
    private readonly EmsDbContext context;
    public EmpController(EmsDbContext _context){
        context=_context;
    }
    public IActionResult List(){
        // var data=context.Employees.ToList();
        var data=context.Employees.Include("Dept").ToList();
        return View(data);
    }
    public IActionResult Create(){
        ViewBag.DeptId=new SelectList(context.Depts,"Id","Name");
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee emp){
        // if(ModelState.IsValid)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        ViewBag.DeptId=new SelectList(context.Depts,"Id","Name");
        return View(emp);
    }
}
