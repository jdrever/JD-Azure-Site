//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>JD Blog Post Comment</summary>
	[PublishedContentModel("jDBlogPostComment")]
	public partial class JDblogPostComment : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "jDBlogPostComment";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public JDblogPostComment(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<JDblogPostComment, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Commenter Email
		///</summary>
		[ImplementPropertyType("commenterEmail")]
		public string CommenterEmail
		{
			get { return this.GetPropertyValue<string>("commenterEmail"); }
		}

		///<summary>
		/// Commenter Name
		///</summary>
		[ImplementPropertyType("commenterName")]
		public string CommenterName
		{
			get { return this.GetPropertyValue<string>("commenterName"); }
		}

		///<summary>
		/// CommentText
		///</summary>
		[ImplementPropertyType("commentText")]
		public string CommentText
		{
			get { return this.GetPropertyValue<string>("commentText"); }
		}
	}
}
