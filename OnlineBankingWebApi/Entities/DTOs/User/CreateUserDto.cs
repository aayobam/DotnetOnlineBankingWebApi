using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.DTOs.UserDto
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "First name cannot be empty.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name cannot be empty")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required.")]
        public DateTime Dob { get; set; }

        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}