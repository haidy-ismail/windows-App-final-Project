﻿using System;
using System.ComponentModel.DataAnnotations;

namespace userControl.Models
{
    public class Safe
    {
        [Key]
        public int رقم_المسلسل { get; set; }
        public string الحركه { get; set; }
        public DateTime التاريخ { get; set; }
        public double? وارد { get; set; }
        public double? منصرف { get; set; }
        public double رصيد { get; set; }
        public double الحساب { get; set; }

    }
}
