using Milestone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    [Key]
    public int Id{get;set;}
    public string ?Name{get;set;}
    [DataType(DataType.EmailAddress)]
    public string ?Email{get;set;}
    public int ?BatchId{get;set;}

    public Batch ?Batch{get;set;}

    


}