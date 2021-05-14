using EF_Core_Cascade_Delete.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_Cascade_Delete.Controllers
{
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {
       
        private readonly ApplicationDbContext _dbContext;

        public BlogsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("insert")]
        public IActionResult Insert()
        {
            var person = new Person
            {
                Name = "1_person",
                OwnedBlog = new List<Blog>()
                {
                    new Blog
                    {
                        Name = "1_Blog",
                    },
                    new Blog
                    {
                        Name = "2_Blog",
                    },
                }
            };

            _dbContext.Add(person);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpGet("delete")]
        public IActionResult Delete()
        {

            var people = _dbContext.People.Single(e => e.Name == "1_person");

            _dbContext.Remove(people);

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
