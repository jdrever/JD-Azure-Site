﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace JD_Azure_Website.Models
{
    public class BlogPostCommentViewModel {  
        //: RenderModel
    //{
    //    public BlogPostCommentViewModel(IPublishedContent content)
    //        : base(content)
     //   {
     //   }

        [Required]
        public string CommentText { get; set; }

        public string Name { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}