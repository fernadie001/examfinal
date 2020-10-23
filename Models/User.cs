using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examfinal.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2)]
        public string Name {get;set;}
        
        [Required]
        [Range(3,15)]
        public string Alias {get;set;}
        
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime DoB {get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password {get;set;}
        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        //One to many of the ideas and 

        public List<Actividad> Commissions {get;set;}

        public List<ActivityHistory> OrderHistory {get;set;}
        
        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get;set;}
    }
}