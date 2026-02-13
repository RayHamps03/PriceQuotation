using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuote
    {
        [Range(0.01, double.MaxValue, ErrorMessage ="Subtotal must be greater than 0.")]
        public double Subtotal { get; set; }

        [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100.")]
        public byte DiscountPercent { get; set; }

        public double DiscountAmount
        {
            get { return Subtotal * DiscountPercent / 100; }
        }

        public double Total
        {
            get { return Subtotal - DiscountAmount; }
        }

    }
}
