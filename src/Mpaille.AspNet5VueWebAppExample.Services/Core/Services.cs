using Mpaille.AspNet5VueWebAppExample.Services.Interfaces;

namespace Mpaille.AspNet5VueWebAppExample.Services.Core
{
    internal class Services : IServices
    {
        public Services(IProductService products)
        {
            Products = products;
        }

        public IProductService Products { get; }
    }
}
