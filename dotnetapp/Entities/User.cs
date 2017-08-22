using System;
using System.Collections.Generic;
using dotnetapp.Code;

namespace dotnetapp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Gender { get; set; }
        public long Birth_date { get; set; }

        internal void Merge(Dictionary<string, object> input)
        {
            if (!(new Validator()).NullValidation(input))
            {
                throw new ArgumentException();
            }

            if (input.TryGetValue("email", out var email))
            {
                Email = (string)email;
                if (Email.Length > 100)
                {
                    throw new ArgumentException();
                }
            }

            if (input.TryGetValue("first_name", out var first_name))
            {
                First_name = (string)first_name;
                if (First_name.Length > 50)
                {
                    throw new ArgumentException();
                }
            }

            if (input.TryGetValue("last_name", out var last_name))
            {
                Last_name = (string)last_name;
                if (Last_name.Length > 50)
                {
                    throw new ArgumentException();
                }
            }

            if (input.TryGetValue("gender", out var gender))
            {
                Gender = (string)gender;
                if (Gender != "f" && Gender != "m")
                {
                    throw new ArgumentException();
                }
            }

            if (input.TryGetValue("birth_date", out var birth_date))
            {
                Birth_date = (long)birth_date;
            }
        }
    }
}