using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Refrigerantes.Validations
{
    public class AnyoValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                if (((string)value).Length <= 0)
                    return new ValidationResult(false, "El año no puede estar vacío.");
            }
            catch (Exception e)
            {
                return new ValidationResult(false, e.Message);
            }
            try
            {
                int anyo = Convert.ToInt32(value);
                int currentYear = DateTime.Now.Year;
                if (anyo < 1950 || anyo > currentYear)
                {
                    return new ValidationResult(false, "El año está fuera de rango [1950 - " + currentYear + "]");
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Debe introducir solo números");
            }

            return new ValidationResult(true, null);
        }
    }
}
