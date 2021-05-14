/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_Backend.Back_End;
using Tarea_Backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NorthwindAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductSC productService = new ProductSC();

        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {   
            var products = productService.GetProducts().Select(s => new ProductDTO
            {
                id = s.ProductId,
                Nombre = s.ProductName,
                UnidadesPorCantidad = s.QuantityPerUnit,
                PrecioPorUnidad = s.UnitPrice,
                UnidadesEnVenta = s.UnitsInStock
            }).ToList();

            return Ok(products);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var product = productService.GetProductById(id);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] ProductModel newProduct)
        {
            try
            {
                productService.AddProduct(newProduct);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProductModel newProduct)
        {
            try
            {
                productService.UpdateProductById(id, newProduct);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                productService.DeleteProductById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        #region helpers

        private IActionResult ThrowInternalErrorServer(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }

        #endregion
    }
}
*/