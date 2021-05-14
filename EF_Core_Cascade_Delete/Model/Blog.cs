using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_Cascade_Delete.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }

      //  public IList<Post> Posts { get; } = new List<Post>();

        public int OwnerId { get; set; }
        public Person Owner { get; set; }
    }
}
