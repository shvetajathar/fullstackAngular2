using Milestone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Milestone.Controllers;

public class BatchController:Controller{

    private readonly BmsDbContext context;

    public BatchController(BmsDbContext _context)
    {
        context=_context;
    }

    
    
    

    

}