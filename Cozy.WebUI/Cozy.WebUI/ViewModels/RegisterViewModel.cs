﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cozy.WebUI.ViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress, Required]
        [Display (Name="EmailAdress")]
        public string Email { get; set; }
        [DataType(DataType.Password), Required]
        public string Password { get; set; }
        [DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords don't match"), Required]
        public string ConfirmedPassword { get; set; }
        [Required, Display (Name = "Select a Role")]
        public string Role { get; set; }
        public SelectList Roles { get; set; }
    }
}
    