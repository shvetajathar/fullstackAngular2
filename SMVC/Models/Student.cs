using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace SMVC.Models;
public class Student
{
    public int ?StudentId{get;set;}
    public string ?StudentName{get;set;}
    public DateTime ?DateOfBirth{get;set;}
    public byte[] ?Photo{get;set;}
    public decimal ?Height{get;set;}
    public float ?Weight{get;set;}
    public Grade ?Grade{get;set;}
}