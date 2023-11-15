using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.Models
{
    public class Account : BaseModel
    {
        [ForeignKey("UserId")]
        public User? User { get; set; }

        [MinLength(10), MaxLength(10)]
        public string AccountNumber { get; set; } = string.Empty;
        public Decimal AccountBalance { get; set; }

        public bool IsVerified { get; set; } = false;
    }
}