using Microsoft.AspNetCore.Mvc;
using Mpaille.AspNet5VueWebAppExample.Services.Core;

namespace Mpaille.AspNet5VueWebAppExample.WebApi.Core
{
    public class BaseController : ControllerBase
    {
        public BaseController(IServices services)
        {
            Services = services;
        }

        protected IServices Services { get; }
    }
}
