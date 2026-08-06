using System.ComponentModel.DataAnnotations;

namespace IINVT.Models
{
    public class Supplier
    {
        [Display(Name = "Supplier ID")]
        public int SupplierID { get; set; }

        [Display(Name = "Supplier Code")]
        public string Code { get; set; }

        [Display(Name = "Supplier Name")]
        public string Name { get; set; }

        [Display(Name = "Supplier Type")]
        public string Type { get; set; }

        [Display(Name = "Supplier Address")]
        public string Address { get; set; }

        [Display(Name = "Supplier Phone")]
        public string Phone { get; set; }

        [Display(Name = "Supplier Email")]
        public string Email { get; set; }
    }
}
