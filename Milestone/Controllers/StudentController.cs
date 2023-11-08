using Milestone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Milestone.Controllers;

public class StudentController:Controller{

    private readonly BmsDbContext context;

    public StudentController(BmsDbContext _context)
    {
        context=_context;
    }

    public IActionResult List()
    {
        return View();
    }
    public IActionResult Index()
    {
        var data=context.Students.ToList();
        return View(data);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student stud)
    {
        if(ModelState.IsValid)
        {
            Student s=new Student();
            s.Name=stud.Name;
            s.Email=stud.Email;
            s.BatchId=stud.BatchId;

            context.Students.Add(s);
            context.SaveChanges();
            return RedirectToAction("Index");
        
        }
        return View();
    }
    public IActionResult Find(int id)
    {
        var data=context.Students.Find(id);
        if(data==null)
        {
            return NotFound();
        }
        return View(data);
    }
    public IActionResult Delete(int id)
    {
        var data=context.Students.Find(id);
        context.Students.Remove(data);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Delete(Student stud)
    {
        Student s=context.Students.Find(stud.Id);
        context.Students.Remove(s);
        context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult BatchEnrollmentForm(int id,string name,string Email)
    {
        Student s=new Student();
        s.BatchId=id;
        s
    }

    


    

    

}