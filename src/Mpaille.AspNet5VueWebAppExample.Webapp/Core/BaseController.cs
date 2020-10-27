using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mpaille.AspNet5VueWebAppExample.Services.Core;

namespace Mpaille.AspNet5VueWebAppExample.Webapp.Core
{
    public abstract class BaseController<TController> : Controller
    {
        public BaseController(ILogger<TController> logger, IServices services)
        {
            Logger = logger;
            Services = services;
        }

        protected ILogger<TController> Logger { get; }
        protected IServices Services { get; }
    }
}
