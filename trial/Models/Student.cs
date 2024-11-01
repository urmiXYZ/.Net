using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace trial.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name cannot be empty!")]
        [RegularExpression(@"^[a-zA-Z._ ]+$", ErrorMessage = "Name can only have alphabets or . or _!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ID cannot be empty!")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "ID format must be XX-XXXXX-1, 2, or 3!")]

        public string ID { get; set; }

        [Required(ErrorMessage = "DOB cannot be empty!")]
        [Date]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Email cannot be empty!")]
        //[RegularExpression(@"^\w{2}-\w{5}-\w@student\.aiub\.edu$", ErrorMessage = "Email format must be XX-XXXXX-X@student.aiub.edu!")]
        [Email]
        public string Email { get; set; }
        
    }
}