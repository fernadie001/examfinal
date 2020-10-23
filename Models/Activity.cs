using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace examfinal.Models
{
    public class Actividad
    {
        [Key]

        public int ActivityId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}

        public User Seller {get;set;}

        public List<ActivityHistory> OrderHistory {get;set;}


    }
}