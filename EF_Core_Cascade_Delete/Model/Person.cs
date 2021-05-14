using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_Cascade_Delete.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

       // public IList<Post> Posts { get; } = new List<Post>();

        public List<Blog> OwnedBlog { get; set; }
    }
}
