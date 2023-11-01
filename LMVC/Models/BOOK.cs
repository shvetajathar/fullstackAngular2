using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LMVC.Models;
[Index(nameof(ID),IsUnique=true)]
public class BOOK
{
    
    // [ForeignKey("BOOK")]
    [Key]
    public int ID{get;set;}
    [Required]
    [StringLength(50)]
    public string ?Author{get;set;}
    [Required]
    [StringLength(100)]
    public string ?Title{get;set;}
    [Range(1,int.MaxValue,ErrorMessage="Published year cannot be negative")]
    public int publishedYear{get;set;}
    public LIBRARYCARD ?librarycard{get;set;}
}