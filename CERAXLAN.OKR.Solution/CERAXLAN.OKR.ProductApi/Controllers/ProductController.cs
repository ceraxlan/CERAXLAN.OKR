using CERAXLAN.Core.Application.Requests;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.CreateProduct;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.DeleteProduct;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.UpdateProduct;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Models;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Queries.GetByIdProduct;
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

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProductGetByIdDto), (int)(HttpStatusCode.OK))]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType((int)(HttpStatusCode.BadRequest))]
        public async Task<IActionResult> GetById([FromRoute] GetByIdProductQuery dto)
        {
            var result = await Mediator.Send(dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(DeletedProductDto), (int)(HttpStatusCode.OK))]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType((int)(HttpStatusCode.BadRequest))]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommand dto)
        {
            var result = await Mediator.Send(dto);
            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(typeof(UpdatedProductDto), (int)(HttpStatusCode.OK))]
        [ProducesResponseType((int)(HttpStatusCode.NotFound))]
        [ProducesResponseType((int)(HttpStatusCode.BadRequest))]
        public async Task<IActionResult> Update([FromBody] UpdateProductCommand dto)
        {
            var result = await Mediator.Send(dto);
            return Ok(result);
        }
    }
}
