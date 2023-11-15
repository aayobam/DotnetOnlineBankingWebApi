using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.DTOs.Account
{
    public class UpdateAccountDto
    {
        public Guid UserId { get; set; }

        public string? AccountNumber { get; set; }
        public Decimal AccountBalance { get; set; }

        public bool IsVerified { get; set; } = false;
    }
}