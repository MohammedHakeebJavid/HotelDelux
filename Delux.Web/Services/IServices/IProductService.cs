using Delux.Web.Models;


namespace Delux.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>(String token);
        Task<T> GetProductByIdAsync<T>(int id, String token);
        Task<T> CreateProductAsync<T>(ProductDto productDto, String token);
        Task<T> UpdateProductAsync<T>(ProductDto productDto, String token);
        Task<T> DeleteProductAsync<T>(int id, String token);
    }
}
