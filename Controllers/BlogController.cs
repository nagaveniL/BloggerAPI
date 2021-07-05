using BlogSiteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogSiteAPI.Controllers
{
    public class BlogController : ApiController
    {

        public BlogController()
        {
            //Todo:
            //Need to declare IArticleRespository via dependency injection
        }

        [Route("api/blog/{name}")]
        [HttpGet]
        public IHttpActionResult
        GetArticleDetails(string name)
        {
            try
            {
                //Todo: Remove and replace later with dependency injection
                ArticleRepository repository = new ArticleRepository(new BlogDBContext());
                var result = repository.GetArticleDetails(name);

                return Ok(result);
            }
            catch(Exception ex)
            {
               return InternalServerError();
            }
           
        }

        [Route("api/blog/")]
        [HttpPost]
        public IHttpActionResult
       PostArticleDetails(Article article)
        {
            try
            {
                //Todo: Remove and replace later with dependency injection
                ArticleRepository repository = new ArticleRepository(new BlogDBContext());

                var results = repository.AddArticleDetails(article);

                if(repository.SaveChanges())
                {
                    return Ok(results);
                }
                else
                {
                    return InternalServerError();
                }
                
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
            return BadRequest();
        }
    }
}