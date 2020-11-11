using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using Microsoft.AspNetCore.Http;

namespace ViewModels.AdminViewModel.User {
    public class Vm_User {
        [Key]
        public int Id { get; set; }
        public string UserNameUs { get; set; }
        public string EmailUS { get; set; }
        public string PhoneUs { get; set; }
        public string PasswordUs { get; set; }
        public string AddressUs { get; set; }
        public string ProfileImageUs { get; set; }
        public string Language { get; set; }

        public string repass { get; set; }
        public IFormFile img { get; set; }
    }

}