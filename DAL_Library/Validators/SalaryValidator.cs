using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library.Validators
{
    public class SalaryValidator : ValidationAttribute
    {
        #region Attributs
        #endregion

        #region Porperties
        #endregion

        #region Constructors
        public SalaryValidator() : base("The salary must be between 0 and 100,000.")
        {
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public override bool IsValid(object value)
        {
            bool result = false;
            float data;
            if(float.TryParse(value.ToString(), out data))
            {
                if (data >= 0 && data <= 100000)
                {
                    result = true;
                }
            }
            return result;
        }
        #endregion
    }
}
