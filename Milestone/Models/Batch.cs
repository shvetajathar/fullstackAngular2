using Milestone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Batch
{
    public int BatchId{get;set;}

    public DateTime StartTime{get;set;}
    // [Range(typeof(DateTime),"1/1/2000","1/1/2000 23:59",ErrorMessage ="End time must be after 1 hour of start time.")]
    public DateTime EndTime{get;set;}
    [Range(1,5,ErrorMessage="Capacity must be between 1 and 5.")]
    public int Capacity{get;set;}

    public ICollection<Student> ?Student{get;set;}
    




}

