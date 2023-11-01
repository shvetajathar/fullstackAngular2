using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;
using LMVC.Models;
namespace LMVC.Controllers;
public class BOOKController:Controller{
    private readonly LmsDbContext context;
    public BOOKController(LmsDbContext _context)
    {
        context=_context;
    }
    
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(BOOK bk)
    {
        // if(ModelState.IsValid)
        {
            context.BOOKs.Add(bk);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

}