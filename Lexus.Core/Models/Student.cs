using Lexus.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Core.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public DateTime BirthDay { get; set; }
        public EnGender Gender { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
