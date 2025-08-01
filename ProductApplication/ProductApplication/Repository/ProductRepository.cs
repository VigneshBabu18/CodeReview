using ProductApi.Data;
using ProductApi.Model;

namespace ProductApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _context;

        public ProductRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll() => _context.Products.ToList();

        public Product GetById(int id)
        {

            

                return _context.Products.Find(id);
            
            
           
            
        }

        public void Add(Product product) => _context.Products.Add(product);

        public void Update(Product product) => _context.Products.Update(product);

        public void Delete(Product product) => _context.Products.Remove(product);

        public void Save() => _context.SaveChanges();
    }
}
