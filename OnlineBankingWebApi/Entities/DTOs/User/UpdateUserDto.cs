using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.DTOs.UserDto
{
    public class UpdateUserDto
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
    }
}