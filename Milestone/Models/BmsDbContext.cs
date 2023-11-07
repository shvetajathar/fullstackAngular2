namespace Milestone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

public class  BmsDbContext:DbContext
{
    public virtual DbSet<Student> Students{get;set;}
    public virtual DbSet<Batch> Batchs{get;set;}

    public BmsDbContext(DbContextOptions<BmsDbContext> options):base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=BmsDb;trusted_connection=false;Persist Security Info=False;Encrypt=False");
        }
    }


}

