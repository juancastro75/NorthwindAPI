using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Backend.Models;

namespace Tarea_Backend.Back_End
{
    public class OrderSC : BaseSC, IUpdate
    {

        public IQueryable<Orders> GetOrders()
        {
            return dataContext.Orders.AsQueryable();
        }

        public Orders GetOrderById(int id)
        {
            return GetOrders().Where(x => x.OrderId == id).First();
        }

        public void AddOrder(OrderModel newOrder)
        {

            var newOrderRegister = new Orders();

            newOrderRegister.Freight = newOrder.Peso;
            newOrderRegister.ShipAddress = newOrder.Direccion;
            newOrderRegister.ShipName = newOrder.EnviadoPor;
            newOrderRegister.OrderDate = newOrder.FechaDePedido;
            newOrderRegister.RequiredDate = newOrder.FechaRequerida;
            newOrderRegister.ShippedDate = newOrder.FechaDeEnvio;

            dataContext.Orders.Add(newOrderRegister);
            dataContext.SaveChanges();
        }

        public void UpdateNameById(int id, string name)
        {
            var currentOrder = new OrderSC().GetOrderById(id);
            currentOrder.ShipName = name;
            dataContext.Orders.Update(currentOrder);
            dataContext.SaveChanges();
        }

        public void UpdateOrderById(int id, OrderModel newOrder)
        {
            var currentOrder = new OrderSC().GetOrderById(id);
            currentOrder.Freight = newOrder.Peso;
            currentOrder.ShipAddress = newOrder.Direccion;
            currentOrder.ShipName = newOrder.EnviadoPor;
            currentOrder.OrderDate = newOrder.FechaDePedido;
            currentOrder.RequiredDate = newOrder.FechaRequerida;
            currentOrder.ShippedDate = newOrder.FechaDeEnvio;
            dataContext.Orders.Update(currentOrder);
            dataContext.SaveChanges();
        }

        public void DeleteOrderById(int id)
        {
            var order = GetOrderById(id);
            dataContext.Orders.Remove(order);
            dataContext.SaveChanges();
        }
    }
}