﻿using Mango.Services.EmailAPI.Message;
using Mango.Services.EmailAPI.Models.Dto;

namespace Mango.Services.EmailAPI.Service.IService
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsMessage);
    }
}
