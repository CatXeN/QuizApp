﻿using System;
using System.ComponentModel.DataAnnotations;

namespace QuizAppAuthApi.Models.Informations
{
    public class UserInformation
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
