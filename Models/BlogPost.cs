using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Falcon_Blog_2.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        // ? means nullable

        public string Title { get; set; }
        public string Slug { get; set; }

        public string Abstract { get; set; }
        [AllowHtml]
        public string Body { get; set; }

        public string MediaUrl { get; set; }

        public bool Published { get; set; }

        //Tell blog model it has potential for children. Post is parent, comments are children
        public virtual ICollection<Comment> Comments { get; set; }

        public BlogPost()
        {
            Comments = new HashSet<Comment>();
        }
    }
}