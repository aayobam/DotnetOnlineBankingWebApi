using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBankingWebApi.Entities.DTOs
{
    public class SendMailDto
    {
        [Required(ErrorMessage = "Receiver Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string ReceiverEmail { get; set; } = null!;

        [Required(ErrorMessage = "Email Subject is required.")]
        public string EmailSubject { get; set; } = null!;

        [Required(ErrorMessage = "Email Body is required.")]
        [DataType(DataType.MultilineText)]
        public string? PlainTextEmailMessage { get; set; }

        [DataType(DataType.Html)]
        public string? HtmlEmailMessage { get; set; }

        public List<IFormFile>? Attachments { get; set; }
    }
}