using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Backend.Models;


namespace Tarea_Backend.Back_End
{
    public class ProductSC : BaseSC, IUpdate
    {

       public IQueryable<Products> GetProducts()
        {
            return dataContext.Products.AsQueryable();
        }

        public Products GetProductByName(String productName)
        {
            return GetProducts().Where(x => x.ProductName == productName).First();
        }
       
        public Products GetProductById(int id)
        {
            return GetProducts().Where(x => x.ProductId == id).First();
        }

        public void AddProduct(ProductModel newProduct)
        {
            var newProductRegister = new Products();

            newProductRegister.ProductName = newProduct.Nombre;
            newProductRegister.QuantityPerUnit = newProduct.UnidadesPorCantidad;
            newProductRegister.UnitPrice = newProduct.PrecioPorUnidad;
            newProductRegister.UnitsInStock = newProduct.UnidadesEnVenta;

            dataContext.Products.Add(newProductRegister);
            dataContext.SaveChanges();
        }

        public void UpdateNameById(int id, string name)
        {
            var currentProduct = new ProductSC().GetProductById(id);
            currentProduct.ProductName = name;
            dataContext.Products.Update(currentProduct);
            dataContext.SaveChanges();
        }

        public void UpdateProductById(int id, ProductModel newProduct)
        {
            var currentProduct = new ProductSC().GetProductById(id);
            currentProduct.ProductName = newProduct.Nombre;
            currentProduct.QuantityPerUnit = newProduct.UnidadesPorCantidad;
            currentProduct.UnitPrice = newProduct.PrecioPorUnidad;
            currentProduct.UnitsInStock = newProduct.UnidadesEnVenta;
            dataContext.Products.Update(currentProduct);
            dataContext.SaveChanges();
        }

        public void DeleteProductById(int id)
        {
            var product = GetProductById(id);
            dataContext.Products.Remove(product);
            dataContext.SaveChanges();
        }
    }
}