

using System.ComponentModel.DataAnnotations;

namespace IINVT.Models
{
    public class Item
    {
        [Display(Name = "Item ID")]
        public int ItemID { get; set; }

        [Display(Name = "Category ID")]
        public int CatID { get; set; }

        [Display(Name = "Subcategory ID")]
        public int SubCatID { get; set; }

        [Display(Name = "Item Name")]
        public string Itemname { get; set; }

        [Display(Name = "Unit")]
        public string Unit { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
