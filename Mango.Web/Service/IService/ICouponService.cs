using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> CreateCuoponAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCuoponAsync(CouponDto cuoponDto);
        Task<ResponseDto?> DeleteCuoponAsync(int id);
    }
}
