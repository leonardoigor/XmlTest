using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using testeXML.entities;

namespace testeXML.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return new ProductEntity(1, "igor", "Programador", 200, 5, "https://stackoverflow.com/").ProductEntityToXML();
        }


    }
}