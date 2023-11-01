using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;
using LMVC.Models;
namespace LMVC.Controllers;
public class LIBRARYCARDController:Controller{
    private readonly LmsDbContext context;
    public LIBRARYCARDController(LmsDbContext _context)
    {
        context=_context;
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(LIBRARYCARD lk)
    {
        if(ModelState.IsValid)
        {
            context.LIBRARYCARDs.Add(lk);
            context.SaveChanges();
            // return RedirectToAction("Index");
            return View();
        }
        return View();
    }

}