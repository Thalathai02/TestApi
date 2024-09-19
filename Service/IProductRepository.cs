using backend.Models;
using backend.ViewModels;

namespace backend.Services
{
    public interface IProductRepository
    {
        public List<TbProduct> GetTbProductsAll();
        public List<TbProduct> SearchProductById(int keyword);
        public Boolean InsertProduct(TbProduct tbProduct);
        public Boolean EditProduct(TbProduct tbProduct,int id);
        public Boolean DeleteProduct(int id);



    }
}
