using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.Models
{
    public class Address : BaseModel
    {

        [Required]
        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required]
        [MinLength(15), MaxLength(100)]
        public string Street { get; set; } = string.Empty;

        [MinLength(10), MaxLength(50)]
        public string City { get; set; } = string.Empty;

        [MinLength(10), MaxLength(50)]
        public string State { get; set; } = string.Empty;
    }
}