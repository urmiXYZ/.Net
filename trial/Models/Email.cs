using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace trial.Models
{
    public class Email : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Student)validationContext.ObjectInstance;
            if (value is string email)
            {
                string id = student.ID;
                if (Regex.IsMatch(id, @"^\d{2}-\d{5}-\d{1}$"))
                {
                    string expectedEmail = $"{id}@student.aiub.edu";
                    if (email.Equals(expectedEmail, StringComparison.OrdinalIgnoreCase))
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return new ValidationResult("Email format must be XX-XXXXX-X@student.aiub.edu and ID must match!");
        }
    }
}
