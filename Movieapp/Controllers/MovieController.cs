using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Movieapp.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Movieapp.Controllers
{
    
    [ApiController]
    [Route("/[controller])")]
    public class MovieController:ControllerBase
    {
        MovieContext context=new MovieContext();

        [HttpGet]

        [Route("ListMovies")]
        public IActionResult Get()
        {

            // var data=context.Movies.ToList();
            var data=from movie in context.Movies join detail in context.Details on Movies.Id equals 
            return Ok(data);
        }

        [HttpGet]

        [Route("ListMovies/{id}")]
        public IActionResult Get(int id)
        {
            // var data=context.Movies.ToList();
            if(id==null)
            {
                return BadRequest("Id cannot be null");
            }
            var data=(from m in context.Movies where m.Id==id select m).FirstOrDefault();
            // var data=context.Movies.Find(id);
            if(data==null)
            {
                return NotFound($"Movie {id} not found");
            }
            return Ok(data);
            
        }
        [HttpPost]
        [Route("AddMovie")]
        public IActionResult Post(Movie movie)
        {
            if(ModelState.IsValid)
            {
                try{
                    context.Movies.Add(movie);
                    context.SaveChanges();

                }
                catch(System.Exception ex){
                    return BadRequest(ex.InnerException.Message);

                }
            }
            return Created("Record Added",movie);

        }
        [HttpPut]
        [Route("EditMovie/{id}")]
        public IActionResult Put(int id,Movie movie)
        {
            if(ModelState.IsValid)
            {
                Movie mv=context.Movies.Find(id);
                mv.Name=movie.Name;
                mv.Rating=movie.Rating;
                mv.YearRelease=movie.YearRelease;
                context.SaveChanges();
                return Ok();
                



            }
            return BadRequest("Unable to Edit Record");
        }
        [HttpDelete]
        [Route("DeleteMovie/{id}")]
        public IActionResult Delete(int id)
        {
            try{
                var detail=context.Details.Where(d=>d.MovieId==id);
                if(detail.Count() !=0)
                {
                    throw new Exception("Cannot delete mocie");
                }
                var data=context.Movies.Find(id);
                context.Movies.Remove(data);
                context.SaveChanges();
                return Ok();
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        
        


    }

}