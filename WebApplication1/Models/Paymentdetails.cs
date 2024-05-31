using System.ComponentModel.DataAnnotations;


namespace Ecommerce.Models
{
    public class Paymentdetails
    {
        
        public int CustomerID;

        public Customer Customer { get; set; }

        [Key]
        public int PaymentDetailId;

        [Required(ErrorMessage = "Card type is required")]
        [Display(Name = "Card Type")]
        public string Cardtype { get; set; }

        [Required(ErrorMessage = "Card number is required")]
        [Display(Name = "Card Number")]
        [StringLength(16, ErrorMessage = "Invalid card numbers entered", MinimumLength = 15)]
        public string CardNo { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Card expiration is required")]
        [Display(Name = "Expiration")]
        public DateTime ExpDate { get; set; }

        public ICollection<Orders> Orders { get; set; }


    }
}