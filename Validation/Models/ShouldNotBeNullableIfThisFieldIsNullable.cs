using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Validation.Models
{
    public class ShouldNotBeNullableIfThisFieldIsNullable : ValidationAttribute
    {
        private readonly string _propertyName;
        public ShouldNotBeNullableIfThisFieldIsNullable(string propertyName)
        {
            _propertyName = propertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
                return null;

            if (GetValueFromOtherField(validationContext) == null)
                return new ValidationResult($"The field {_propertyName} should be informed if this field were nullable");

            return null;
        }

        private object GetValueFromOtherField(ValidationContext validationContext)
        {
            var obj = validationContext.ObjectInstance;
            return obj.GetType().GetProperty(_propertyName).GetValue(obj);
        }
    }
}