﻿using System;

namespace LENDELTA.Core.ViewModels.Account
{
    public class UpdateProfileViewModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Gender { get; set; }
        public string Avatar { get; set; }
    }
}
