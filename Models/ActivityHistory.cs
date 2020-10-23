using System;
using System.ComponentModel.DataAnnotations;

namespace examfinal.Models
{
    public class ActivityHistory
    {
        [Key]

        public int orderId {get;set;}
            //Got Activity

            //What the activity is 
        public int UserId {get;set;}
        
        public int ActivityId {get;set;}

        // public string Request {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Client {get;set;}

        public Actividad Activity {get;set;}

    }    

}