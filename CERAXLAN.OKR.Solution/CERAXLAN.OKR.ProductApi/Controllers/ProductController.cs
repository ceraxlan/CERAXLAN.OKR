using CERAXLAN.Core.Application.Requests;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.CreateProduct;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Models;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Queries.GetListProduct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CERAXLAN.OKR.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(CreatedProductDto), (int)(HttpStatusCode.OK))]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType((int)(HttpStatusCode.BadRequest))]
        public async Task<IActionResult> Add([FromBody] CreateProductCommand dto)
        {
            var result = await Mediator.Send(dto);
            return Created("", result);
        }


        [HttpGet]
        [ProducesResponseType(typeof(ProductListModel), (int)(HttpStatusCode.OK))]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType((int)(HttpStatusCode.BadRequest))]
        public async Task<IActionResult> GetList()//([FromQuery] PageRequest pageRequest)
        {
            PageRequest pageRequest = new PageRequest();
            var getListProductQuery = new GetListProductQuery { PageRequest = pageRequest };
            var result = await Mediator.Send(getListProductQuery);
            return Ok(result);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById([FromRoute] GetByIdProductQuery dto)
        //{
        //    var productGetByIdDto = await Mediator.Send(dto);
        //    return Ok(productGetByIdDto);
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete([FromRoute] DeleteProductCommand dto)
        //{
        //    var result = await Mediator.Send(dto);
        //    return Ok(result);
        //}

        //[HttpPut]
        //public async Task<IActionResult> Update([FromBody] UpdateProductCommand dto)
        //{
        //    var result = await Mediator.Send(dto);
        //    return Ok(result);
        //}




        //private readonly ProductDbContext _dbContext;

        //public ProductController(ProductDbContext productDbContext)
        //{
        //    _dbContext = productDbContext;
        //}

        //[HttpGet]
        //public ActionResult<IEnumerable<Product>> GetProducts()
        //{
        //    return _dbContext.Products;
        //}

        //[HttpGet("{productId:int}")]
        //public async Task<ActionResult<Product>> GetById(int productId)
        //{
        //    var product = await _dbContext.Products.FindAsync(productId);
        //    return product;
        //}

        //[HttpPost]
        //public async Task<ActionResult> Create(Product product)
        //{
        //    await _dbContext.Products.AddAsync(product);
        //    await _dbContext.SaveChangesAsync();
        //    return Ok();
        //}

        //[HttpPut]
        //public async Task<ActionResult> Update(Product product)
        //{
        //    _dbContext.Products.Update(product);
        //    await _dbContext.SaveChangesAsync();
        //    return Ok();
        //}

        //[HttpDelete("{productId:int}")]
        //public async Task<ActionResult> Delete(int productId)
        //{
        //    var product = await _dbContext.Products.FindAsync(productId);
        //    _dbContext.Products.Remove(product);
        //    await _dbContext.SaveChangesAsync();
        //    return Ok();
        //}
    }
}
