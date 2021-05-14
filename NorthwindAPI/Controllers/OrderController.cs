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
    public class OrderController : ControllerBase
    {
        private OrderSC orderService = new OrderSC();

        // GET: api/<OrderController>
        [HttpGet]
        public IActionResult Get()
        {
            var orders = orderService.GetOrders().Select(s => new OrderDTO
            {
                id = s.OrderId,
                Peso = s.Freight,
                Direccion = s.ShipAddress,
                EnviadoPor = s.ShipName,
                FechaDePedido = s.OrderDate,
                FechaRequerida = s.RequiredDate,
                FechaDeEnvio = s.ShippedDate
            }).ToList();

            return Ok(orders);
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var order = orderService.GetOrderById(id);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<OrderController>
        [HttpPost]
        public IActionResult Post([FromBody] OrderModel newOrder)
        {
            try
            {
                orderService.AddOrder(newOrder);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] OrderModel newOrder)
        {
            try
            {
                orderService.UpdateOrderById(id, newOrder);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                orderService.DeleteOrderById(id);
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