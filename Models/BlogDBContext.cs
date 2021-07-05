using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace BlogSiteAPI.Models
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext()
        {
            /*
            Database.SetInitializer(
                new Article()
                { AuthorName = "Chinmay", AuthorDescription = "Scientific 1.0 Achiver, Chill guy", AuthorDesignation = "Software developer", BlogTitle = "Scientic method", ArticleTitle = "Sci Method 1.0", ArticleText = "Blah blah"
                }) ;
            */
        }

        public DbSet<Article> article { get; set; }

    }

  //  public class BlogDBInitialiser : 

}