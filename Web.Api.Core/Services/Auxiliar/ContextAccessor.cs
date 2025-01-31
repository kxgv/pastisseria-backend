using System.Security.Claims;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Infrastructure;
using Web.Api.Core.Interfaces.Auxiliar;

namespace Web.Api.Core.Services.Auxiliar
{
    public class ContextAccessor //: IContextAccessor
    {
        //private IHttpContextAccessor _httpContextAccessor;
        //public HttpContext Context => _httpContextAccessor.HttpContext;

        //public ContextAccessor(IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //}
        //public UserAuthData GetUserAuthData()
        //{
        //    if (_httpContextAccessor.HttpContext == null)
        //    {
        //        return new UserAuthData();
        //    }

        //    var user = _httpContextAccessor.HttpContext.User;
        //    return new UserAuthData
        //    {
        //        UserId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value,
        //        UserRegionId = Convert.ToInt32(user.FindFirst(SharedConstants.ClaimRegionId)?.Value),
        //        UserInfoId = Convert.ToInt32(user.FindFirst(SharedConstants.ClaimUserInfoId)?.Value),
        //        UserEmail = user.FindFirst(ClaimTypes.Email)?.Value,
        //        UserBusinessIds = user.FindAll(SharedConstants.ClaimBusinessIds).Select(e => int.Parse(e.Value)).ToList(),
        //        RolesNames = user.FindAll(ClaimTypes.Role).Select(rn => rn.Value).ToList()
        //    };
        //}
    }
}
