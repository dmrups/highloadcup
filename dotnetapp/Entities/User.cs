using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Entities
{
    public class User
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get;set;}
        public string Email{get;set;}
        public string First_name{get;set;}
        public string Last_name{get;set;}
        public string Gender{get;set;}
        public long Birth_date{get;set;}
    }
}