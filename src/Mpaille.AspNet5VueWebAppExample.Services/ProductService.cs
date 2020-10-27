using Mpaille.AspNet5VueWebAppExample.Models;
using Mpaille.AspNet5VueWebAppExample.Repositories.Core;
using Mpaille.AspNet5VueWebAppExample.Services.Core;
using Mpaille.AspNet5VueWebAppExample.Services.Interfaces;
using System.Threading.Tasks;

namespace Mpaille.AspNet5VueWebAppExample.Services
{
    internal class ProductService : BaseService, IProductService
    {
        public ProductService(IRepositories repositories) : base(repositories) { }

        async Task<ProductModel> IProductService.AddProductAsync(ProductModel product)
        {
            return await Repositories.Products.AddProductAsync(product);
        }

        async Task<ProductModel> IProductService.DeleteProductByIdAsync(int id)
        {
            return await Repositories.Products.DeleteProductByIdAsync(id);
        }

        async Task<ProductModel> IProductService.GetProductByIdAsync(int id)
        {
            return await Repositories.Products.GetProductByIdAsync(id);
        }

        async Task<ProductModel> IProductService.UpdateProductAsync(ProductModel product)
        {
            return await Repositories.Products.UpdateProductAsync(product);
        }
    }
}
