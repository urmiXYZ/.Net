using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.WebPages;

namespace trial.Models
{
    public class Date : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value is string dobstring && DateTime.TryParse(dobstring, out DateTime dob))
            {
                var age = DateTime.Today.Year - dob.Year;
                if (dob.Date>DateTime.Today.AddYears(- age)) age--;
                if (age > 20) return ValidationResult.Success;
            }
            return new ValidationResult("Age cannot be less than 21!");
        }
    }
}