using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Core.Client.App.Models
{
    public class Login
    {
        [DisplayName("E-mail address")]
        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string Grant_Type { get; set; }

    }
}
