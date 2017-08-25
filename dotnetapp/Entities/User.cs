using System;
using System.Collections.Generic;
using dotnetapp.Code;

namespace dotnetapp.Entities
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public long birth_date { get; set; }

        internal void Merge(Dictionary<string, object> input)
        {
            if (!(new Validator()).NullValidation(input))
            {
                throw new ArgumentException();
            }

            if (input.TryGetValue("email", out var email))
            {
                this.email = (string)email;
                if (this.email.Length > 100)
                {
                    throw new ArgumentException();
                }
            }

            if (input.TryGetValue("first_name", out var first_name))
            {
                this.first_name = (string)first_name;
                if (this.first_name.Length > 50)
                {
                    throw new ArgumentException();
                }
            }

            if (input.TryGetValue("last_name", out var last_name))
            {
                this.last_name = (string)last_name;
                if (this.last_name.Length > 50)
                {
                    throw new ArgumentException();
                }
            }

            if (input.TryGetValue("gender", out var gender))
            {
                this.gender = (string)gender;
                if (this.gender != "f" && this.gender != "m")
                {
                    throw new ArgumentException();
                }
            }

            if (input.TryGetValue("birth_date", out var birth_date))
            {
                this.birth_date = (long)birth_date;
            }
        }
    }

    public class UserArr
    {
        public User[] users { get; set; }
    }
}