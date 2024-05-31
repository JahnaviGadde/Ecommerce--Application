using System.ComponentModel.DataAnnotations;


namespace Ecommerce.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone must be 10 digits")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection <Address> Address { get; set; }
        public ICollection <Paymentdetails> Paymentdetails { get; set; }
    }
}