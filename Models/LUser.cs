using System;
using System.ComponentModel.DataAnnotations;

namespace examfinal.Models
{
    public class LUser
    {
        [Required]
        [EmailAddress]
        public string LEmail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string LPassword {get;set;}
    }
}