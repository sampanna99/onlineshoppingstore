﻿using OnlineShoppingStore.Domain.Entities;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string sessionkey = "Cart";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Cart cart = null;
            if (controllerContext.HttpContext.Session != null)
            {
                cart = (Cart)controllerContext.HttpContext.Session[sessionkey];
            }

            if (cart == null)
            {
                cart = new Cart();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionkey] = cart;
                }
            }
            return cart;
        }
    }
}