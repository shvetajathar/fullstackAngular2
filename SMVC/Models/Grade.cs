using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace SMVC.Models;
public class Grade{
    public int ?GradeId{get;set;}
    public string ?GradeName{get;set;}
    public string ?Section{get;set;}
    public ICollection<Student> ?Student{get;set;}
}