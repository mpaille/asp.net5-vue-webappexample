using Mpaille.AspNet5VueWebAppExample.Repositories.Interfaces;

namespace Mpaille.AspNet5VueWebAppExample.Repositories.Core
{
    public interface IRepositories
    {
        IProductRepository Products { get; }
    }
}
