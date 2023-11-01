using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations.Schema;


namespace LMS_CodeFirst.Models;
[Index(nameof(Id),IsUnique=true)]
public class Book
{
    [ForeignKey("Book")]
    public int Id{get;set;}
    public string Title{get;set;}
    public string author{get;set;}
    public int publishedYear{get;set;}
    public LibraryCard Librarycard{get;set;}
}
