using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.DTOs.User
{
    public class LoginDto
    {
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}