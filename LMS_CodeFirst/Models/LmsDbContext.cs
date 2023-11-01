using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace LMS_CodeFirst.Models;

public class LMS_CodeFirstDbContext:DbContext
{
    public virtual DbSet<LibraryCard> Libraries{get;set;}
    public virtual DbSet<LibraryCard> LibraryCards{get;set;}
    public LMS_CodeFirstDbContext(){}
    public LMS_CodeFirstDbContext(DbContextOptions<LMS_CodeFirstDbContext> options):base(options){}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=LmsDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");

        }
    }
    

}


