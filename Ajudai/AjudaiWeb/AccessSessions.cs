using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace AjudaiWeb
{
    /// <summary> 
    /// Só permite acesso se as sessões existirem
    /// </summary> 
    public class AccessSessions : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            RouteValueDictionary redirectTargetDictionary = new RouteValueDictionary();

            //se não estiver autenticado
            if (!IsAuthorized(HttpContext.Current))
            {
                FormsAuthentication.SignOut();
                redirectTargetDictionary.Add("action", "Index");
                redirectTargetDictionary.Add("controller", "Login");
                redirectTargetDictionary.Add("area", "");

                filterContext.Result = new RedirectToRouteResult(redirectTargetDictionary);
            }/*
            //se estiver autenticado
            else
            {
                filterContext.Result = null;         
            }*/

            base.OnActionExecuting(filterContext);
        }

        /// <summary> 
        /// Verifica se as sessões existem
        /// </summary> 
        /// <returns></returns> 
        public static bool IsAuthorized(HttpContext httpContext)
        {
            // check  sessions here
            if (httpContext.Session["ssCodUsuario"] == null)
            {
                return false;
            }
            else if(httpContext.Session["ssLogin"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}