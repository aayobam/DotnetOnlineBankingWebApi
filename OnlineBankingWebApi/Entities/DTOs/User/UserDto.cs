using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using OnlineBankingWebApi.Entities.Models;

namespace OnlineBankingWebApi.Entities.DTOs.UserDto
{
    public class UserDto : BaseModel
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime Dob { get; set; }

        public int Age { get; set; }

        public string? EmailAddress { get; set; }
    }
}