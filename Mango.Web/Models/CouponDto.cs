namespace Mango.Web.Models
{
    public class CouponDto
    {
        public int CuoponId { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
