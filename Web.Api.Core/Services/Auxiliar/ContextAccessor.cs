using Microsoft.AspNetCore.Http;
using Web.Api.Core.Interfaces.Auxiliar;
using Web.Api.Common.Dtos.Auth;

namespace Web.Api.Core.Services.Auxiliar
{
    public class ContextAccessor : IContextAccessor
    {
        private IHttpContextAccessor _httpContextAccessor;
        public HttpContext Context => _httpContextAccessor.HttpContext;

        public ContextAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public UserAuthDataDto GetUserAuthData()
        {
            if (_httpContextAccessor.HttpContext == null)
            {
                return new UserAuthDataDto();
            }

            var user = _httpContextAccessor.HttpContext.User;
            return new UserAuthDataDto
            {
                UserName = user.Identity?.Name,
                IsAuthenticated = user.Identity.IsAuthenticated,
            };
        }
    }
}
