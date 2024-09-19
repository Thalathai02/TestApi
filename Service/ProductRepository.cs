using System.Linq;
using backend.Database;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using backend.ViewModels;

// using backend.Installers;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace backend.Services
{
    public class ProductRepository : IProductRepository
    {

        private readonly DatabaseContext _context;

        public IMapper Mapper { get; }

        public ProductRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
        }
        public List<TbProduct> GetTbProductsAll()
        {
            List<TbProduct> getData = _context.TbProducts.ToList();
            return getData;

        }
        public List<TbProduct> SearchProductById(int keyword)
        {
            return (from product in _context.TbProducts
                    where EF.Functions.Like(product.Id.ToString(), "%" + keyword + "%")
                    select product).ToList();
        }
        public Boolean InsertProduct(TbProduct tbProduct)
        {
            if (string.IsNullOrEmpty(tbProduct.ProductName))
                throw new Exception("ProductName can't null");

            bool Models = false;
            try
            {
                tbProduct.CreateDate = DateTime.Now;
                tbProduct.IsDelete = false;

                tbProduct.UpdateBy = null;
                tbProduct.UpdateDate = null;


                _context.TbProducts.Add(tbProduct);
                Models = _context.SaveChanges() > 0 ? true : false;

            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }

            return Models;
        }

        public Boolean EditProduct(TbProduct tbProduct, int id)
        {
            if (string.IsNullOrEmpty(tbProduct.ProductName))
                throw new Exception("ProductName can't null");

            bool Models = false;
            try
            {

                TbProduct checkedId = _context.TbProducts.Find(id);
                // checkedId
                checkedId.UpdateBy = tbProduct.UpdateBy;
                checkedId.IsDelete = tbProduct.IsDelete;
                checkedId.UpdateDate = tbProduct.UpdateDate;
                checkedId.ProductName = tbProduct.ProductName;


                _context.TbProducts.Update(checkedId);
                Models = _context.SaveChanges() > 0 ? true : false;

            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }

            return Models;
        }


        public Boolean DeleteProduct(int id)
        {

            bool Models = false;
            try
            {

                TbProduct checkedId = _context.TbProducts.Find(id);
                _context.TbProducts.Remove(checkedId);
                Models = _context.SaveChanges() > 0 ? true : false;

            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }

            return Models;
        }

    }

}
