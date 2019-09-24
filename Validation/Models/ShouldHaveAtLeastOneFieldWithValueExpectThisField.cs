using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Models
{
    public class ShouldHaveAtLeastOneFieldWithValueExpectThisField : ValidationAttribute
    {
        public readonly string [] _expectFields;
        public ShouldHaveAtLeastOneFieldWithValueExpectThisField(params string[] expectFields)
        {
            _expectFields = expectFields;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var obj = validationContext.ObjectInstance;
            var otherProperties = obj.GetType().GetProperties().Where(x => !_expectFields.Any(y => y == x.Name)).ToList();
            var hasOneDifferentThenNull = otherProperties.Any(x => x.GetValue(obj) != null);

            if (!hasOneDifferentThenNull)
                return new ValidationResult($"At least one field should be with value");

            return null;
        }
    }
}