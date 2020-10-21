using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuizAppModels.Models.Informations
{
    public class UserInformation
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
