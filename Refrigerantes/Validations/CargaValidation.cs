using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Controls;

namespace Refrigerantes.Validations
{
    public class CargaValidation : ValidationRule
    {
        const decimal CARGA_MIMNIMA = (decimal)0.1;
        const decimal CARGA_MAXIMA = (decimal)100.0;
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                if (value == null)
                    return new ValidationResult(false, "El valor no puede ser nulo.");

                decimal cargaValor;

                // Intentar convertir el valor a decimal
                if (decimal.TryParse(value.ToString(), out cargaValor))
                {
                    if (cargaValor > CARGA_MAXIMA || cargaValor < CARGA_MIMNIMA)
                    {
                        return new ValidationResult(false, $"La carga no puede ser superior a {CARGA_MAXIMA} ni inferior a {CARGA_MIMNIMA}");
                    }
                }
                else
                {
                    return new ValidationResult(false, "El valor ingresado no es un número válido.");
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(false, e.Message);
            }

            return new ValidationResult(true, null);
        }

    }
}
