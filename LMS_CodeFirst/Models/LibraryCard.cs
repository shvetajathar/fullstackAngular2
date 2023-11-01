using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
namespace LMS_CodeFirst.Models;
[Index(nameof(Id),IsUnique=true)]
public class LibraryCard
{
    
    public int Id{get;set;}
    public string CardNumber{get;set;}
    public string MemberName{get;set;}
    public DateTime ExpiryDate{get;set;}

    public ICollection<Book> Book{get;set;}
}
