using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Movieapp.Models
{
    public class Movie{
        [Key]
        public int Id{get;set;}
        [Required]
        public string ?Name{get;set;}
        public int YearRelease{get;set;}
        public int Rating{get;set;}
        public ICollection<Detail> ?Details{get;set;}






    }
}

