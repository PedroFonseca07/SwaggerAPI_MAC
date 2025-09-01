using SwaggerApi.Models;
using SwaggerApi.Repositories;

namespace SwaggerApi.Services
{
   public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> GetAllProducts() => _productRepository.GetAllProducts();

    public Product GetProductById(int id) => _productRepository.GetProductById(id);

    public void CreateProduct(Product product) => _productRepository.CreateProduct(product);

    public void UpdateProduct(Product product) => _productRepository.UpdateProduct(product);

    public void DeleteProduct(int id) => _productRepository.DeleteProduct(id);
}

}