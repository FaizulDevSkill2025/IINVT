using System.ComponentModel.DataAnnotations;

namespace IINVT.Models
{
    public class Unit
    {
        [Display(Name = "Unit ID")]
        public int UnitID { get; set; }

        [Display(Name = "Unit Name")]
        public string UnitName { get; set; }

        [Display(Name = "Unit Code")]
        public string Code { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
