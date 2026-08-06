using System.ComponentModel.DataAnnotations;

namespace IINVT.Models
{
    public class Customer
    {
        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Display(Name = "Customer Type")]
        public string Type { get; set; }

        [Display(Name = "Customer Address")]
        public string Address { get; set; }

        [Display(Name = "Customer Code")]
        public string Code { get; set; }

        [Display(Name = "Customer Phone")]
        public string Phone { get; set; }

        [Display(Name = "Customer Email")]
        public string Email { get; set; }
    }
}
