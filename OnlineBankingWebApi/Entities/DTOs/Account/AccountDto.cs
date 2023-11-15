using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBankingWebApi.Entities.DTOs.UserDto;
using OnlineBankingWebApi.Entities.Models;

namespace OnlineBankingWebApi.Entities.DTOs.Account
{
    public class AccountDto : BaseModel
    {
        public Guid UserId { get; set; }

        public string AccountNumber { get; set; } = null!;

        public Decimal AccountBalance { get; set; }

        public bool IsVerified { get; set; } = false;
    }
}