using Mpaille.AspNet5VueWebAppExample.Models;
using Mpaille.AspNet5VueWebAppExample.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Mpaille.AspNet5VueWebAppExample.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        Task<ProductModel> IProductRepository.AddProductAsync(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        Task<ProductModel> IProductRepository.DeleteProductByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<ProductModel> IProductRepository.GetProductByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<ProductModel> IProductRepository.UpdateProductAsync(ProductModel product)
        {
            throw new System.NotImplementedException();
        }
    }
}
