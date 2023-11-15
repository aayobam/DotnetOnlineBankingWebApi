using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.DTOs.User
{
    public class UserData
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime Dob { get; set; }

        public int Age { get; set; }

        public string EmailAddress { get; set; } = null!;
    }
}