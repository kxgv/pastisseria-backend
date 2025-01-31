using Microsoft.AspNetCore.Http;
using Web.Api.Core.Interfaces.Auxiliar;
using Web.Api.Common.Dtos.Auth;

namespace Web.Api.Core.Services
{
    public abstract class BaseService
    {
        protected UserAuthDataDto _userAuthData;
        protected readonly HttpContext _httpContext;

        protected BaseService(IContextAccessor contextAccessor)
        {
            _httpContext = contextAccessor.Context;
            _userAuthData = contextAccessor.GetUserAuthData();
        }
    }
}
