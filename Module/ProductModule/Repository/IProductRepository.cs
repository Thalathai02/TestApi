using backend.Module.ProductModule.Models;

namespace backend.Module.ProductModule.Repository
{
    public interface IProductRepository
    {
        public List<TbProduct> GetTbProductsAll();
        public List<TbProduct> SearchProductById(int keyword);
        public bool InsertProduct(TbProduct tbProduct);
        public bool EditProduct(TbProduct tbProduct, int id);
        public bool DeleteProduct(int id);



    }
}
