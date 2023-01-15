using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.Models
{
    internal class البضاعه
    {
        [Key]
        public int رقم_الصنف { get; set; }
        public string اسم_الصنف { get; set; }
        public double سعر_البيع { get; set; }
        public int اجمالي_الكميه { get; set; }
        public double سعر_الشراء { get; set; }
        public string الوصف { get; set; }


        public virtual الفواتير الفواتير { get; set; }
        public virtual شراء شراء { get; set; }
        public virtual بيع بيع { get; set; }
        public virtual مرتجع_بيع مرتجع_بيع { get; set; }
        public virtual مرتجع_شراء مرتجع_شراء { get; set; }
        public virtual البضاعه بضاعه { get; set; }

    }
}
