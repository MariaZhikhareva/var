using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace var5lab2
{
    class NotEmptyValidationRule : ValidationRule
    {
        public Int64 MaxNum { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Double i = 0;
            try
            {
                i = Convert.ToDouble(value);
            }
            catch (Exception)
            {
                return new ValidationResult(false, "это не число!");
            }
            if (i > MaxNum || i <= 0)
                return new ValidationResult(false, "Много цифр!");
            else
                return new ValidationResult(true, String.Empty);
            
        }
        
    }

}
