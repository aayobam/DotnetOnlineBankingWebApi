using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.DTOs.User
{
    public class CreateJwtTokenDto
    {
        public UserData User { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string RefreshToken { get; set; } = string.Empty;
    }
}