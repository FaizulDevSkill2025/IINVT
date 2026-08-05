namespace IINVT.Models
{
    public class Subcategory
    {
        public int SubCategoryID { get; set; } 
        public int CategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }
    }
}
