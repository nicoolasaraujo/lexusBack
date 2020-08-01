using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Core.Models
{
    public class User
    {
        public User() { }

        public User(Guid id, string username, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
    }
}
