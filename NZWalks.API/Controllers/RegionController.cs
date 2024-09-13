using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() 
        {
           var regions=new List<Region>
           {
               new Region
               {
                   Id=Guid.NewGuid(),
                   Name="Auckland Region",
                   Code="AKL",
                   RegionImageUrl=""
               },
               new Region
               {
                   Id=Guid.NewGuid(),
                   Name="Auckland Region",
                   Code="AKL",
                   RegionImageUrl=""
               }
           }

        
        }
    }
}
