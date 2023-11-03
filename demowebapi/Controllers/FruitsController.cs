using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace demoswpapi.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class FruitsController:ControllerBase
    {
        static List<string> Fruits=new List<string>{"Apple","Mango","Orange","Grapes","Banana"};
        [HttpGet]
        [Route("ShowFruits")]
        public IEnumerable<string> GetFruits()
        {
            return Fruits;
        }
        [HttpGet]
        [Route("ShowFruits/{id}")]
        public string GetFruits(int id)
        {
            return Fruits[id];
        }
        [HttpPost]
        [Route("AddFruit")]
        public void Post([FromBody] string data)
        {
            Fruits.Add(data);
        }


    }



