using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace EMS_CodeFirst.Models;
[Table("Department")]
public class Dept
{
    public int id{get;set;}
    [Required(ErrorMessage="Name cannot be Blank")]

    public string Name{get;set;}
    [MaxLength(30)]
    [Column("DeptName")]
    public string Loaction{get;set;}
    public ICollection<Employee> Employees{get;set;}


}

