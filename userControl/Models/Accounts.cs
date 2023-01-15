using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userControl.Models
{
    internal class Accounts
    {
        public int رقم_الحساب { get; set; }
        public string اسم_الحساب { get; set; }
        public double مدين { get; set; }
        public double دائن { get; set; }
        public string طبيعه_الحساب { get; set; }
        public string التصنيف { get; set; }
        public int كود_الحساب { get; set; }
        public string العنوان { get; set; }
        public string التليفون { get; set; }
    }
}
