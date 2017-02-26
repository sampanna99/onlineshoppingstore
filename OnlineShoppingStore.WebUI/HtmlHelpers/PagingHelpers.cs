﻿using OnlineShoppingStore.WebUI.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < pagingInfo.Totalpages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.Currentpage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");

                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());

            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}