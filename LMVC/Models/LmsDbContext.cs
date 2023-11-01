using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LMVC.Models;
public class LmsDbContext:DbContext
{
    public virtual DbSet<BOOK> BOOKs{get;set;}
    public virtual DbSet<LIBRARYCARD> LIBRARYCARDs{get;set;}

    public LmsDbContext()
    {

    }
    public LmsDbContext(DbContextOptions<LmsDbContext> options):base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=LmsDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<BOOK>().HasOne(b=>b.librarycard).WithOne(lc=>lc.BOOK).HasForeignKey<LIBRARYCARD>(lc=>lc.BOOK.ID);
    //     modelBuilder.Entity<LIBRARYCARD>().HasMany(lc=>lc.book).WithOne(b=>b.librarycard).HasForeignKey(b=>b.ID);
    // }
    

}