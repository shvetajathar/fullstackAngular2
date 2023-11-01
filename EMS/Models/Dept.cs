using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EMS.Models;
 
public partial class Dept
{
    public int Id { get; set; }
    [Display(Name ="Department Name")]
    [Required(ErrorMessage ="Department Name Cannot Blank")]
    public string Name { get; set; } = null!;
    [Display(Name="City")]
    [StringLength(25,MinimumLength =3,ErrorMessage ="City Must be 3 Chars")]
    public string? Location { get; set; }
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}