using DAL_Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library.Database
{
    public class EmployeeContext : DbContext
    {
        #region Attributs
        private DbSet<Employee> employees;
        private DbSet<Service> services;
        #endregion

        #region Porperties
        public DbSet<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public DbSet<Service> Services
        {
            get { return services; }
            set { services = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public EmployeeContext() : base() => System.Data.Entity.Database.SetInitializer<EmployeeContext>(new MyInitializer());

        //Disable initializer
        //public EmployeeContext() : base() => Database.SetInitializer<EmployeeContext>();
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Entity<Employee>().HasRequired(e => e.Department).WithMany(s => s.Employees);
            base.OnModelCreating(dbModelBuilder);
        }
        #endregion

    }
}
