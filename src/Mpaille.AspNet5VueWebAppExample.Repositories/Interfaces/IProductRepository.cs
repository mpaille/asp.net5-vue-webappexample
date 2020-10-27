using Mpaille.AspNet5VueWebAppExample.Models;
using System.Threading.Tasks;

namespace Mpaille.AspNet5VueWebAppExample.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductModel> GetProductByIdAsync(int id);
        Task<ProductModel> AddProductAsync(ProductModel product);
        Task<ProductModel> UpdateProductAsync(ProductModel product);
        Task<ProductModel> DeleteProductByIdAsync(int id);
    }
}
