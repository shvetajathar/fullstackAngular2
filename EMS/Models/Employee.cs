using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EMS.Models;
 
public partial class Employee
{
    public int EmpId { get; set; }
    [Required(ErrorMessage="Name is required")]
    public string? Name { get; set; }
    [Range(10000,90000,ErrorMessage="Salary between 10000 and 90000")]
    public int Salary { get; set; }
    [Display(Name="Department")]
    public int DeptId { get; set; }
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:yyyy-MM-dd}")]
    [DobCheck(ErrorMessage ="You should be 25 years old to work in LTIMindtree")]
    public DateTime Dob { get; set; }
 
    public virtual Dept Dept { get; set; } = null!;
}