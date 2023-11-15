using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.DTOs.Account
{
    public class CreateAccountDto
    {
        public Guid UserId { get; set; }

        [MinLength(10), MaxLength(10)]
        public string AccountNumber { get; set; } = string.Empty;
        
        public Decimal AccountBalance { get; set; }

        public bool IsVerified { get; set; } = false;
    }
}