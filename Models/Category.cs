using System.ComponentModel.DataAnnotations;

namespace IINVT.Models
{
    public class Category
    {
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
