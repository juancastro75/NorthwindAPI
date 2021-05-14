using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Backend.Models;


namespace Tarea_Backend.Back_End
{
    public class EmployeeSC : BaseSC, IUpdate
    {

        public IQueryable<Employees> GetEmployees()
        {
            return dataContext.Employees.Select(s => s);
        }

        public Employees GetEmployeeById(int id)
        {
            return GetEmployees().Where(x => x.EmployeeId == id).First();
        }

        public void AddEmployee(EmployeeModel newEmployee)
        {
            var newEmployeeRegister = new Employees();

            newEmployeeRegister.FirstName = newEmployee.Nombre;
            newEmployeeRegister.LastName = newEmployee.Apellido;
            newEmployeeRegister.Country = newEmployee.Pais;
            newEmployeeRegister.City = newEmployee.Ciudad;
            newEmployeeRegister.Address = newEmployee.Direccion;
            //newEmployeeRegister.BirthDate = newEmployee.Nacimiento;

            dataContext.Employees.Add((Employees)newEmployeeRegister);
            dataContext.SaveChanges();

        }

        public void getAllLondonEmployees()
        {
            var employeeQuery = dataContext.Employees.Select(s => s).Where(w => w.City == "London").AsQueryable();
            var output = employeeQuery.ToList();
        }

        
        public void getAllNorthEmployees(int id)
        {
            List<Employees> reportsToEmployee = GetEmployeeReportsTo(id);

            if (reportsToEmployee == null)
                throw new Exception("No se encontró el empleado con el ID proporcionado");

            foreach (var employee in reportsToEmployee)
            {
                employee.Region = "North";
            }

            dataContext.SaveChanges();
        }

        public void DeleteEmployeeById(int id)
        {
            var employee = GetEmployeeById(id);
            dataContext.Employees.Remove(employee);
            dataContext.SaveChanges();
        }

        private List<Employees> GetEmployeeReportsTo(int id)
        {
            return dataContext.Employees.Select(s => s).Where(w => w.ReportsTo == id).ToList();
        }        

        public void UpdateEmployeeById(int id, EmployeeModel newEmployee)
        {
            var currentEmployee = new EmployeeSC().GetEmployeeById(id);
            currentEmployee.FirstName = newEmployee.Nombre;
            currentEmployee.LastName = newEmployee.Apellido;
            currentEmployee.Country = newEmployee.Pais;
            currentEmployee.City = newEmployee.Ciudad;
            currentEmployee.Address = newEmployee.Direccion;
            currentEmployee.BirthDate = newEmployee.Nacimiento;
            dataContext.Employees.Update(currentEmployee);
            dataContext.SaveChanges();
        }


        public void UpdateNameById(int id, string name)
        {
            var currentEmployee = new EmployeeSC().GetEmployeeById(id);
            currentEmployee.FirstName = name;
            dataContext.Employees.Update(currentEmployee);
            dataContext.SaveChanges();
        }
    }
}
