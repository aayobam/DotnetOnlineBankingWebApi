using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.Models
{
    public class VerificationOtp : BaseModel
    {
        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required]
        public string Code { get; set; } = null!;

        [Required]
        public DateTime Expiry { get; set; }
    }
}