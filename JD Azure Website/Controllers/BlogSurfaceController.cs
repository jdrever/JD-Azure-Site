using JD_Azure_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;

namespace JD_Azure_Website.Controllers
{
    public class BlogSurfaceController : SurfaceController
    {
        public ActionResult DisplayListOfComments()
        {
            return PartialView("JDListOfBlogComments", new BlogPostCommentViewModel());
        }

        public ActionResult PostComment(BlogPostCommentViewModel comment)
        {
            if (!ModelState.IsValid)
            {
                //Not valid - so lets return the user back to the view with the data they entered still prepopulated
                return CurrentUmbracoPage();
            }
;
            var commentNode = Services.ContentService.CreateContent(
            "Comment made: "+DateTime.Now.ToLongDateString(), // Node Name - what I want to call the new child node
            CurrentPage.Id, // Parent Node we want to add to
            "JDBlogPostComment", // The alias of the Document Type
            0); // Umbraco User ID this will be created by, default 0
            commentNode.SetValue("comment", comment.Comment);
            commentNode.SetValue("emailAddress", comment.EmailAddress);
            commentNode.SetValue("name", comment.Name);
            Services.ContentService.SaveAndPublishWithStatus(commentNode);

            return RedirectToCurrentUmbracoPage();
        }
    }
}