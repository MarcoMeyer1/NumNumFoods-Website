namespace NumNumFoods.Models
{
    public class Voucher
    {
        public int VoucherId { get; set; } // Unique identifier for the voucher
        public string Code { get; set; } // The code for the voucher
        public int DiscountPercent { get; set; } // The discount percentage
        public int? MaxUses { get; set; } // Maximum uses for the voucher, nullable
        public DateTime ExpiryDate { get; set; } // Expiry date of the voucher
        public int Uses { get; set; } // Number of times the voucher has been used
    }
}
