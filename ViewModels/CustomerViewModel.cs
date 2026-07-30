using IINVT.Models;

namespace IINVT.ViewModels
{
    public class CustomerViewModel
    {
        public int TotalCustomer { get; set; }
        public int TotalLocal { get; set; }
        public int TotalForeign { get; set; }

        public List<Customer> Customers { get; set; }
        public int TotalCustomers { get; internal set; }
    }
}
