using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.Models
{
    public class Loan
    {
        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}