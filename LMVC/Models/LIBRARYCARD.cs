using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LMVC.Models;
[Index(nameof(Id),IsUnique=true)]
public class LIBRARYCARD
{

    public int Id{get;set;}
    [RegularExpression(@"^LC-\d{5}$",ErrorMessage="cardnumber should follow the format LC-XXXXX")]
    public string? CardNumber{get;set;}
    [ForeignKey("BOOK")]
    public int BookId{get;set;}
    public string? MemberName{get;set;}
    [DataType(DataType.Date)]
    // [FutureDate(ErrorMessage="Expiry date must be future date")]
    public DateTime ExpiryDate{get;set;}
    
    public ICollection<BOOK> ?book{get;set;}


}