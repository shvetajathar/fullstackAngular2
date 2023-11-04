using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Movieapp.Models
{
    public class Detail{
        [Key]
        
        public int DetailId{get;set;}
        [Required]
        [MaxLength(30)]
        public string ?Actor{get;set;}
        [ForeignKey("Movie")]
        public int MovieId{get;set;}
        [MaxLength(10)]
        public string ?Gender{get;set;}
        public string ?Role{get;set;}
        public Movie ?Movie{get;set;}


        

        




    }
}