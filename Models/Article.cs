using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogSiteAPI.Models
{
    [Table("Article")]
    public class Article
    {
        [Key]
        public string AuthorName {get;set;}

        public string AuthorDescription {get;set;}

        public string AuthorDesignation {get;set;}

        public string BlogTitle {get;set;}

        public string ArticleTitle {get;set;}

        public string ArticleText {get;set;}
    }
}