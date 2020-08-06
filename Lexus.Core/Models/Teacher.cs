using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Core.Models
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }
        public User User {get;set;}
        public string PhotoPath { get; set; }        
        public string EmailAddres { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
