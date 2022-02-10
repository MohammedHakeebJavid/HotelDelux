
using Delux.Services.CouponAPI.Models.Dto;

namespace Delux.Services.CouponAPI.Respository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
