using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userControl.Models
{
    public class Invoice
    {
        public int رقم_الفاتوره { get; set; }
        public DateTime التاريخ { get; set; }
        public string الحساب { get; set; }
        public string طريقه_الحساب { get; set; }
        public int الكميه { get; set; }
        public double الخصم { get; set; }
        public double النهائي { get; set; }
        public double درج_النقديه { get; set; }

        internal object FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
