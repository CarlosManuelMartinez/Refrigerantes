﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CarlosManuelMartinezPomaresBikeStores_WPF.Validations
{
    public class NombreValidation : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                if (((string)value).Length <= 0)
                    return new ValidationResult(false, "El nombre no puede estar vacío");
            }
            catch (Exception e)
            {
                return new ValidationResult(false, e.Message);
            }

            if ((((string)value).Length < Min) || (((string)value).Length > Max))
            {
                return new ValidationResult(false,
                    "El nombre debe contener al menos " + Min + " caracteres y no superar  " + Max + " caracteres.");
            }
            return new ValidationResult(true, null);
        }


    }
}
