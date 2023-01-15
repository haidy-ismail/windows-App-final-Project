﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.Models
{
    internal class بيع
    {
        [Key]

        public int رقم_الصنف { get; set; }
        public string اسم_الصنف { get; set; }
        public string وحده { get; set; }
        public int الكميه { get; set; }
        public double السعر { get; set; }
        public double الاجمالي { get; set; }
        public double النهائي { get; set; }

        //public virtual البضاعه البضاعه { get; set; }

    }
}
