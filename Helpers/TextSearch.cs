using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Falcon_Blog_2.Models;

namespace Falcon_Blog_2.Helpers
{
    public class TextSearch
    {
        public static IQueryable<BlogPost> IndexSearch(string searchStr)
        {
            var db = new ApplicationDbContext();
            IQueryable<BlogPost> result = null;
            if (searchStr != null)
            {
                result = db.BlogPosts.AsQueryable();
                result = result.Where(p => p.Title.Contains(searchStr) || p.Body.Contains(searchStr) || p.Comments.Any(c => c.Body.Contains(searchStr) || c.Author.FirstName.Contains(searchStr) || c.Author.LastName.Contains(searchStr) || c.Author.DisplayName.Contains(searchStr) || c.Author.Email.Contains(searchStr)));
            }
            else
            {
                result = db.BlogPosts.AsQueryable();
            }
            return result.OrderByDescending(p => p.Created);
        }
    }
}