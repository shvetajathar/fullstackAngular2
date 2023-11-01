using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace SMVC.Models;

public class SmsDbContext:DbContext{
    public virtual DbSet<Student> Students{get;set;}
    public virtual DbSet<Grade> Grades{get;set;}

    public SmsDbContext()
    {

    }
    public SmsDbContext(DbContextOptions<SmsDbContext> options ):base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=SmsDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }

}
