using System.ComponentModel.DataAnnotations;

namespace IINVT.Models
{
    public class Subcategory
    {
        [Display(Name = "Sub Category ID")]
        public int SubCategoryID { get; set; }

        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Display(Name = "Sub Category Name")]
        public string SubCategoryName { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        public virtual Category Category { get; set; }
    }
}
