using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Helpers
{
    public class CustomResponse<T>
    {
        public bool Success { get; set; }

        public string Messages { get; set; } = string.Empty;

        public T? Data { get; set; }

        public string StatusCode { get; set; } = string.Empty;
    }
}