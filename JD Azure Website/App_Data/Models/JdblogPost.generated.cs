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
	/// <summary>JD Blog Post</summary>
	[PublishedContentModel("JDBlogPost")]
	public partial class JdblogPost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "JDBlogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public JdblogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<JdblogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return this.GetPropertyValue<IHtmlString>("content"); }
		}

		///<summary>
		/// Published Date: Intended to overwrite the Created Date (where a blog post was written previously)
		///</summary>
		[ImplementPropertyType("publishedDate")]
		public DateTime PublishedDate
		{
			get { return this.GetPropertyValue<DateTime>("publishedDate"); }
		}

		///<summary>
		/// Tags
		///</summary>
		[ImplementPropertyType("tags")]
		public IEnumerable<string> Tags
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("tags"); }
		}
	}
}
