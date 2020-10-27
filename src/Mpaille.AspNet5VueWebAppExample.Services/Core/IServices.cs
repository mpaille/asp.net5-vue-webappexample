using Mpaille.AspNet5VueWebAppExample.Services.Interfaces;

namespace Mpaille.AspNet5VueWebAppExample.Services.Core
{
    public interface IServices
    {
        IProductService Products { get; }
    }
}
