namespace Mango.Web.Utility
{
    public class StandardDetails
    {
        public static string CouponAPIBase { get; set; }

        public static string AuthAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
