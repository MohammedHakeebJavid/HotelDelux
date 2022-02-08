

using Delux.Services.ShoppingCartAPI.Models.Dto;

namespace Delux.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
