using Blog.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
    public class Post :BaseEntity
    {
        public string Text { get; set; }
        public int UpdateCount { get; set; }
       
       
       
        
    }
}
