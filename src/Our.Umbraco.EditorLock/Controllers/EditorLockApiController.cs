using System;
using System.Net;
using System.Net.Http;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace Our.Umbraco.EditorLock.Controllers
{
    [PluginController("OurUmbracoEditorLock")]
    public class EditorLockApiController : UmbracoAuthorizedApiController
    {
        public HttpResponseMessage GetNuCacheFile(string contentType)
        {
            try
            {
                var response = "";

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}