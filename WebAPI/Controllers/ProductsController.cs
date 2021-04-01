using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Swagger

        //Loosely coupled -- gevşek/esnek bağımlılık
        //naming convention
        //IoC Container -- Inversion of Control
        IProductServices _productService;
        //Dependency injection
        public ProductsController(IProductServices productService)
        {
            _productService = productService;
        }
         
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //// Dependency chain -- bağımlılık zinciri IProductService ProductManager a ihtiyaç duyuyor. ProductManager da IProdutDal a ihtiyaç duyuyor .
            //IProductService productService = new ProductManager(new EfProductDal());
             
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addtransaction")]
        public IActionResult AddTransaction(Product product)
        {
            var result = _productService.AddTransactionTest(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}