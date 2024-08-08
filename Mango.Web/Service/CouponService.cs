using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCuoponAsync(CouponDto cuoponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.POST,
                Data = cuoponDto,
                Url = StandardDetails.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCuoponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.DELETE,
                Url = StandardDetails.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.GET,
                Url = StandardDetails.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.GET,
                Url = StandardDetails.CouponAPIBase + "/api/coupon/GetByCode/" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.GET,
                Url = StandardDetails.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCuoponAsync(CouponDto cuoponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.PUT,
                Data = cuoponDto,
                Url = StandardDetails.CouponAPIBase + "/api/cuopon"
            });
        }
    }
}
