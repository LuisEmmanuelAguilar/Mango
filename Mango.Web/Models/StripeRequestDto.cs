using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Mango.Web.Models
{
    public class StripeRequestDto
    {
        public string StripeSessionUrl { get; set; }
        public string StripeSssionId { get; set; }
        public string ApprovedUrl { get; set; }
        public string CancelUrl { get; set; }
        public OrderHeaderDto OrderHeader { get; set; }
    }
}
