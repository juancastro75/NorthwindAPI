using System;
using Tarea_Backend.Models;
using Tarea_Backend.Back_End;
using System.Linq;

namespace Tarea_Backend
{
    class Program
    {
        public static EmployeeSC employeeService = new EmployeeSC();
        public static OrderSC orderService = new OrderSC();
        public static ProductSC productService = new ProductSC();

        #region EmployeeFunctions

        /*public static void AddEmployee()
        {
            var newEmployeeAdd = new Employees();

            Console.WriteLine("\nEscribe el nombre del nuevo empleado: ");
            newEmployeeAdd.FirstName = Console.ReadLine();
            Console.WriteLine("\nEscribe el apellido del nuevo empleado: ");
            newEmployeeAdd.LastName = Console.ReadLine();

            employeeService.AddEmployee(newEmployeeAdd);
        }*/

        public static void UpdateEmployee()
        {
            employeeService.UpdateNameById(1, "Andres");
        }

        #endregion

        #region OrderFunctions

        /*public static void AddOrder()
        {
            var newOrderAdd = new Orders();

            Console.WriteLine("\nEscribe el nombre de la ruta de la nueva orden: ");
            newOrderAdd.ShipName = Console.ReadLine();
            Console.WriteLine("\nEscribe la ciudad de la nueva orden: ");
            newOrderAdd.ShipCountry = Console.ReadLine();

            orderService.AddOrder(newOrderAdd);
        }*/

        public static void UpdateOrder()
        {
            orderService.UpdateNameById(10248, "Rio Bravo");
        }

        #endregion

        #region ProductFunctions

        public static void UpdateProduct()
        {
            productService.UpdateNameById(1, "Queso Oaxaca");
        }

        #endregion

        static void Main(string[] args)
        {
            //AddEmployee();
        }

        
    }
}
