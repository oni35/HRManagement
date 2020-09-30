using DAL_Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library.Database
{
    internal class MyInitializer : CreateDatabaseIfNotExists<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Service service = new Service();
                service.Name = "Service" + i.ToString();
                service.Description = "Description of the service" + i.ToString();
                context.Services.Add(service);
                context.SaveChanges();
            }

            for (int i = 0; i < 30; i++)
            {
                Employee employee = new Employee();
                employee.LastName = "Lastname" + i.ToString();
                employee.FirstName = "Firstname" + i.ToString();
                //employee.DateOfBirth = DateTime.Now;
                employee.Town = "Town" + i.ToString();
                employee.Salary = 1000F + i * 10;
                employee.Function = "Function" + i.ToString();
                employee.Department = context.Services.Find(random.Next(1, context.Services.Count()));
                context.Employees.Add(employee);
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}
