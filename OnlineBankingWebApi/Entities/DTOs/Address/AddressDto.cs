using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using OnlineBankingWebApi.Entities.DTOs.User;

namespace OnlineBankingWebApi.Entities.DTOs
{
    public class AddressDto
    {
        public Guid UserId { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
    }
}