using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userControl.Models
{
    public class oldProducts
    {
       
        public int رقم_الصنف { get; set; }
        public string اسم_الصنف { get; set; }
        public double سعر_البيع { get; set; }
        public int اجمالي_الكميه { get; set; }
        public double سعر_الشراء { get; set; }
        public string الوصف { get; set; }


        ////[JsonIgnore] ignore when serialized
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
