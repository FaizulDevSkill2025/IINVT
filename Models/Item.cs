using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;

namespace IINVT.Models
{
    public class Item
    {
        [Display(Name = "Item ID")]
        public int ItemID { get; set; } 


        [Display(Name = "Category ID")]
        
        public int CategoryID { get; set; } 


        [Display(Name = "Sub Category ID")]
        public int SubCategoryID { get; set; } [ForeignKey("SubCategoryID")]

        [Display(Name = "Unit ID")]
        public int UnitID { get; set; } [ForeignKey("UnitID")]

        [Display(Name = "Code")]
        public string Code { get; set; }

        [Display(Name = "Item Name")]
        public string Itemname { get; set; }


        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }


        [Display(Name = "Sub Category Name")]
        public string SubCategoryName { get; set; }


        [Display(Name = "Unit Name")]
        public string UnitName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual Unit Unit { get; set; }
        public virtual Category Category { get; set; }
        public virtual Subcategory Subcategory { get; set; }
    }
}
