using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniCommerce.UI.Filter
{
    public class AuthorizeFilter : ActionFilterAttribute, IActionFilter
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //try
            //{
                if (string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Authorization"]))
                {
                    filterContext.HttpContext.Response.Redirect("/User/SignIn");
                }

            //}
            //catch (Exception)
            //{
            //    filterContext.HttpContext.Response.Redirect("/User/SignIn");
            //}
        //}
        //public override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    //try
        //    //{
        //        if (string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Authorization"]) && (filterContext.HttpContext.Request.Cookies["Authorization"]) != "/User/SignIn")
        //        {
        //            filterContext.HttpContext.Response.Redirect("/User/SignIn");
        //        }

        //    //}
        //    //catch (Exception)
        //    //{
        //    //    filterContext.HttpContext.Response.Redirect("/User/SignIn");
        //    //}
        }
    }

}
