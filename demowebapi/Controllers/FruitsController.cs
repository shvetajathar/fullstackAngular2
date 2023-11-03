using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace demoswpapi.Controllers;
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitsController:ControllerBase
    {
        static List<string> Fruits=new List<string>{"Apple","Mango","Orange","Grapes","Banana"};

    }
}


