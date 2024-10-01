﻿using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class OrderService : IOrderService
    {
        private readonly IBaseService _baseService;
        public OrderService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateOrderAsync(CartDto cartDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.POST,
                Data = cartDto,
                Url = StandardDetails.CouponAPIBase + "/api/coupon/CreateOrder"
            });
        }
    }
}