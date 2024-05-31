using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int AddressID {  get; set; }
        public Address Address { get; set; }
        public int PaymentdetailsID {  get; set; }
        public Paymentdetails Paymentdetails { get; set; }

        public List<int> ProductId = new List<int>(); 
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime OrderDate { get; set; }
    }
}
