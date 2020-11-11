using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace DataLayer.AdminEntities.User {
    public class Tb_User {
        [Key]
        public int Id { get; set; }
        public string UserNameUs { get; set; }
        public string EmailUS { get; set; }
        public string PhoneUs { get; set; }
        public string PasswordUs { get; set; }
        public string AddressUs { get; set; }
        public string ProfileImageUs { get; set; }
        public string Language { get; set; }

    }

}