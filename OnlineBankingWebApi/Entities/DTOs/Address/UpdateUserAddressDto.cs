using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using OnlineBankingWebApi.Entities.DTOs.UserDto;

namespace OnlineBankingWebApi.Entities.DTOs.Address
{
    public class UpdateUserAddressDto
    {
        public Guid UserId { get; set; }

        [Required]
        [MinLength(15), MaxLength(100)]
        public string Street { get; set; } = string.Empty;

        [MinLength(10), MaxLength(50)]
        public string City { get; set; } = string.Empty;

        [MinLength(10), MaxLength(50)]
        public string State { get; set; } = string.Empty;
    }
}