﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBattle1.Shared
{
   public  class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [StringLength(16,ErrorMessage ="Your username is too long (16 characters max.)")] 
        public string UserName { get; set; }

        public string Bio  { get; set; }
        [Required, StringLength(100, MinimumLength =6)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="The passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Range(0, 1000, ErrorMessage = "Please choose a umber between 0 and 1000.")]
        public int Bananas { get; set; } = 100;

        public string StarUnitId { get; set; } = "1";

        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users can play.")]
        public bool IsConfirmed { get; set; } = true;



    }
}
