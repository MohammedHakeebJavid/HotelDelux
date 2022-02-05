using AutoMapper;
using Delux.Services.ProductAPI.DbContexts;
using Delux.Services.ProductAPI.Models;
using Delux.Services.ProductAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;


namespace Delux.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return _mapper.Map<Product, ProductDto>(product);
        }
      

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await _db.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
                if (product == null)
                {
                    return false;
                }
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await _db.Products.Where(x=>x.ProductId==productId).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> productList = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);

        }

        public async Task<ProductDto> UpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
            return _mapper.Map<Product, ProductDto>(product);
            
        }
    }
}
