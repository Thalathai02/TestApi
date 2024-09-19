using AutoMapper;
using backend.Database;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using backend.ViewModels;

namespace backend.Controllers;

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
    public Boolean InsertProduct(TbProduct tbProduct)
    {
        bool success = _product.InsertProduct(tbProduct) ? true : false;

        return success;
    }

    [HttpPut("EditProduct/{id}")]
    public Boolean EditProduct(TbProduct tbProduct, int id)
    {
        bool success = _product.EditProduct(tbProduct, id) ? true : false;
        return success;
    }

    [HttpDelete("DeleteProduct/{id}")]
    public Boolean DeleteProduct(int id)
    {
        bool success = _product.DeleteProduct(id) ? true : false;
        return success;
    }





}