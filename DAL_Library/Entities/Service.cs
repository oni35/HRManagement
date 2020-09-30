using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library.Entities
{
    public class Service
    {
        #region Attributs
        private long serviceId;
        private string name;
        private string description;
        private List<Employee> employees;
        #endregion

        #region Properties
        public long ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }

        [Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Service()
        {
            this.Employees = new List<Employee>();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion
    }
}
