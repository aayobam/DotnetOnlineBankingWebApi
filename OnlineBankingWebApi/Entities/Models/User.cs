using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineBankingWebApi.Entities.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime Dob { get; set; }

        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public override string? Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public Account? Account { get; set; }

        public Address? Address { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
    }
}