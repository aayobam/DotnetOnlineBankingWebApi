using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace OnlineBankingWebApi.Entities.DTOs.User
{
    public class SetPasswordDto
    {
        [DataType(DataType.Password)]
        [MinLength(10)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [MinLength(10)]
        public string ConfirmPassword { get; set; }
    }
}