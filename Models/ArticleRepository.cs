using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSiteAPI.Models
{
    public class ArticleRepository : IArticleRespository
    {
        private readonly BlogDBContext _blogDBContext;

        public ArticleRepository(BlogDBContext blogDBContext)
        {
            _blogDBContext = blogDBContext;
        }
        public IQueryable<Article> GetArticleDetails(string name)
        {
            return _blogDBContext.article.Where(x => x.AuthorName == name);
        }

        public Article AddArticleDetails(Article article)
        {
             return _blogDBContext.article.Add(article);           
        }

        public bool SaveChanges ()
        {
            return _blogDBContext.SaveChanges() > 0;
        }

    }
}