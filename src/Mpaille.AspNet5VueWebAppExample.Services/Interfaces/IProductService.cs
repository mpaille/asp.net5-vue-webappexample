using Mpaille.AspNet5VueWebAppExample.Models;
using System.Threading.Tasks;

namespace Mpaille.AspNet5VueWebAppExample.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductModel> GetProductByIdAsync(int id);
        Task<ProductModel> AddProductAsync(ProductModel product);
        Task<ProductModel> UpdateProductAsync(ProductModel product);
        Task<ProductModel> DeleteProductByIdAsync(int id);
    }
}
