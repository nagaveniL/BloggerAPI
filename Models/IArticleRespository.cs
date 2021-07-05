using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteAPI.Models
{
    interface IArticleRespository
    {
        IQueryable<Article> GetArticleDetails(string name);
    }
}
