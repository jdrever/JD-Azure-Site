//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
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
	// Mixin content Type 1096 with alias "JDBasePage"
	/// <summary>JD Base Page</summary>
	public partial interface IJdbasePage : IPublishedContent
	{
		/// <summary>Body Text</summary>
		IHtmlString BodyText { get; }
	}

	/// <summary>JD Base Page</summary>
	[PublishedContentModel("JDBasePage")]
	public partial class JdbasePage : PublishedContentModel, IJdbasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "JDBasePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public JdbasePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<JdbasePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body Text
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return GetBodyText(this); }
		}

		/// <summary>Static getter for Body Text</summary>
		public static IHtmlString GetBodyText(IJdbasePage that) { return that.GetPropertyValue<IHtmlString>("bodyText"); }
	}
}