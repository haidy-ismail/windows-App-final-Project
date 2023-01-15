using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.Models
{
    internal class الفواتير
    {

        public DateTime التاريخ { get; set; }
        [Key]
        public int رقم_الفاتوره { get; set; }
        public string الحساب { get; set; }
        public string طريقه_الحساب { get; set; }
        public int الكميه { get; set; }
        public double الخصم { get; set; }
        public double النهائي { get; set; }
        public double درج_النقديه { get; set; }

        public virtual ICollection<البضاعه> البضاعه { get; set; }
    }
}
