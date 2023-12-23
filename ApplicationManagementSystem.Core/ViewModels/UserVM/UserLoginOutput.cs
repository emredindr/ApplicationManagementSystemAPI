﻿using ApplicationManagementSystem.Core.Enums;

namespace ApplicationManagementSystem.Core.ViewModels.UserVM
{
    public class UserLoginOutput
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public UserRole Role { get; set; }
        public string Token { get; set; }
    }
}

