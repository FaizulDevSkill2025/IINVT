using IINVT.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IINVT.ViewModels
{
    public class ItemViewModel
    {
        [Display(Name = "Item ID")]
        public int ItemID { get; set; }

        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Subcategory ID")]
        public int SubCategoryID { get; set; }

        [Display(Name = "Subcategory Name")]
        public string SubCategoryName { get; set; }

        [Display(Name = "Item Name")]
        public string Itemname { get; set; }

        [Display(Name = "Unit ID")]
        public int UnitID { get; set; }

        [Display(Name = "Unit Name")]
        public string Unitname { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        public List<SelectListItem> Units { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Subcategories  { get; set; } = new List<SelectListItem>();
        public virtual Subcategory Subcategory { get; set; }
        public virtual Category Category { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
