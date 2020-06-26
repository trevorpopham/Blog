using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Falcon_Blog_2.Models
{
    public class Comment
    {
        // The PK of the comment
        public int Id { get; set; }
        // This is PK of BlogPost that comment belongs to
        public int BlogPostId { get; set; }

        // What is Primary Key of user that wrote comment
        public string AuthorId { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public string UpdateReason { get; set; }

        public string Body { get; set; }

        // Navigational properties
        public virtual BlogPost BlogPost { get; set; }
        public virtual ApplicationUser Author { get; set; }
    }
}