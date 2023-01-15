using System;
using System.ComponentModel.DataAnnotations;

namespace userControl.Models
{
    public class Actions
    {
        [Key]
        public int رقم_الحركة { get; set; }
        public string نوع_الحركة { get; set; } // بيع,شراء,مرتجع بيع,مرتجع شراء
        public DateTime تاريخ_الحركة { get; set; }
        public double المبلغ { get; set; }
    }
}
