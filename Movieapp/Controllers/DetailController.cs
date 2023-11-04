using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Movieapp.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Movieapp.Controllers
{
    
    [ApiController]
    [Route("/[controller])")]
    public class DetailController:ControllerBase
    {
        MovieContext context=new MovieContext();

        [HttpGet]

        [Route("ListDetails")]
        public IActionResult Get()
        {
            // var data=from movie in context.Movies join detail in context.Details on movie.Id equals  detail.MovieId select new
            // {
            //     movie.Name,
            //     detail.Actor,
            //     detail.Role


            // };
            var data=from d in context.Details select new{
                d.Movie.Name,
                d.Actor,
                d.Role

            };
            return Ok(data.ToList());
        }
        [HttpGet]

        [Route("MovieDetails/{id}")]
        public IActionResult Get(int id)
        {
            var data=from d in context.Details select new{
                d.Movie.Name,
                d.Actor,
                d.Role

            };
            return Ok(data.ToList());
        }

        // [HttpGet]

        // [Route("ListDetails/{id}")]
        // public IActionResult Get(int id)
        // {
        //     // var data=context.Movies.ToList();
        //     if(id==null)
        //     {
        //         return BadRequest("Id cannot be null");
        //     }
        //     var data=(from m in context.Details where m.DetailId==id select m).FirstOrDefault();
        //     // var data=context.Movies.Find(id);
        //     if(data==null)
        //     {
        //         return NotFound($"Detail {id} not found");
        //     }
        //     return Ok(data);
            
        // }
        [HttpPost]
        [Route("AddDetail")]
        public IActionResult Post(Detail detail)
        {
            if(ModelState.IsValid)
            {
                try{
                    context.Details.Add(detail);
                    context.SaveChanges();

                }
                catch(System.Exception ex){
                    return BadRequest(ex.InnerException.Message);

                }
            }
            return Created("Record Added",detail);

        }
        [HttpPut]
        [Route("EditDetail/{id}")]
        public IActionResult Put(int id,Detail detail)
        {
            if(ModelState.IsValid)
            {
                Detail d=context.Details.Find(id);
                d.Actor=detail.Actor;
                d.Gender=detail.Gender;
                d.Role=detail.Role;
                d.MovieId=detail.MovieId;
                context.SaveChanges();
                return Ok();
                



            }
            return BadRequest("Unable to Edit Record");
        }
        [HttpDelete]
        [Route("DeleteDetail/{id}")]
        public IActionResult Delete(int id)
        {
            
                var data=context.Details.Find(id);
                
                context.Details.Remove(data);
                context.SaveChanges();
                return Ok();
            
            
        }
        
        


    }

}