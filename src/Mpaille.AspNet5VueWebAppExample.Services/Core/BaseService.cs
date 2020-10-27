using Mpaille.AspNet5VueWebAppExample.Repositories.Core;

namespace Mpaille.AspNet5VueWebAppExample.Services.Core
{
    internal abstract class BaseService
    {
        public BaseService(IRepositories repositories)
        {
            Repositories = repositories;
        }

        protected IRepositories Repositories { get; }
    }
}
