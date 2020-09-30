using DAL_Library.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library.Entities
{
    public class Employee
    {
        #region Attributs
        private long employeeId;
        private string lastName;
        private string firstName;
        //private DateTime dateOfBirth;
        private string town;
        private float salary;
        private string function;
        private Service department;

        #endregion

        #region Properties
        public long EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        [Required]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [Required]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        //public DateTime DateOfBirth
        //{
        //    get { return dateOfBirth; }
        //    set { dateOfBirth = value; }
        //}

        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        [SalaryValidator]
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        [Required]
        public string Function
        {
            get { return function; }
            set { function = value; }
        }

        [Required]
        public Service Department
        {
            get { return department; }
            set { department = value; }
        }

        #endregion

        #region Constructors
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion
    }
}
