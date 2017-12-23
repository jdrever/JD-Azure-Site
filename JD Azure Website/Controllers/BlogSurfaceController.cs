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
        public ActionResult DisplayCommentForm()
        {
            return PartialView("JDBlogCommentForm", new BlogPostCommentViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostComment(BlogPostCommentViewModel comment)
        {
            if (!ModelState.IsValid)
            {
                //Not valid - so lets return the user back to the view with the data they entered still prepopulated
                return CurrentUmbracoPage();
            }
;
            var commentNode = Services.ContentService.CreateContent(
            "Comment made: "+DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToShortTimeString(), // Node Name - what I want to call the new child node
            CurrentPage.Id, // Parent Node we want to add to
            "JDBlogPostComment", // The alias of the Document Type
            0); // Umbraco User ID this will be created by, default 0
            commentNode.SetValue("commentText", comment.CommentText);
            commentNode.SetValue("commenterEmail", comment.EmailAddress);
            commentNode.SetValue("commenterName", comment.Name);
            Services.ContentService.SaveAndPublishWithStatus(commentNode);

            return RedirectToCurrentUmbracoPage();
        }
    }
}