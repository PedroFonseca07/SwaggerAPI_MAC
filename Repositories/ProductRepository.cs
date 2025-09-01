using SwaggerApi.Models;

namespace SwaggerApi.Repositories
{
   public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public IEnumerable<Product> GetAllProducts() => _products;

    public Product GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

    public void CreateProduct(Product product) => _products.Add(product);

    public void UpdateProduct(Product product)
    {
        var index = _products.FindIndex(p => p.Id == product.Id);
        if (index != -1)
        {
            _products[index] = product;
        }
    }

    public void DeleteProduct(int id)
    {
        var product = GetProductById(id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}
}