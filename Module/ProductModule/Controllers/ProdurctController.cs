using AutoMapper;
using backend.Database;
using Microsoft.AspNetCore.Mvc;
using backend.Module.ProductModule.Models;
using backend.Module.ProductModule.Repository;
using backend.Module.ProductModule.ViewModels;

namespace backend.Module.ProductModule.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdurctController : ControllerBase
{
    private readonly ILogger<ProdurctController> _logger;
    private readonly IProductRepository _product;
    private readonly IMapper _mapper;

    public ProdurctController(ILogger<ProdurctController> logger, IProductRepository product, IMapper mapper)
    {
        _logger = logger;
        _product = product;
        _mapper = mapper;
    }

    [HttpGet("GetAllProducts")]
    public List<TbProductViewModel> GetAllProducts()
    {
        var getData = _product.GetTbProductsAll();
        List<TbProductViewModel> products = _mapper.Map<List<TbProductViewModel>>(getData);
        return products;
    }

    [HttpPost("InsertProduct")]
    public bool InsertProduct(TbProduct tbProduct)
    {
        bool success = _product.InsertProduct(tbProduct) ? true : false;

        return success;
    }

    [HttpPut("EditProduct/{id}")]
    public bool EditProduct(TbProduct tbProduct, int id)
    {
        bool success = _product.EditProduct(tbProduct, id) ? true : false;
        return success;
    }

    [HttpDelete("DeleteProduct/{id}")]
    public bool DeleteProduct(int id)
    {
        bool success = _product.DeleteProduct(id) ? true : false;
        return success;
    }





}