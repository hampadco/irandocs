using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace ViewModels.AdminViewModel.Order {
    public class Vm_Order {
      [Key]
        public int Id { get; set; }
        public int Id_user { get; set; }
        public DateTime Date_Order { get; set; }


    }

}