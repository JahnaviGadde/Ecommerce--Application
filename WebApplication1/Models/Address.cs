using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
       
        [DisplayName("Addressline1")]
        [Required(ErrorMessage = "Adress is required")]
        public string Addressline1 { get; set; }

        [DisplayName("Street")]
        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage ="City is required")]
        public string City { get; set; }

        [DisplayName("State")]
        [Required(ErrorMessage = "City is required")]
        public string State { get; set; }

        [DisplayName("PostalCode")]
        [Required(ErrorMessage = "PostalCode is required")]
        [StringLength(6 , MinimumLength = 6 , ErrorMessage = "Must be 6 digits")]
        public string PostalCode { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone must be 10 digits")]
        public string Phone { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}