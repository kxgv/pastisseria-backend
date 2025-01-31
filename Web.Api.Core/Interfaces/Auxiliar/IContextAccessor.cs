using Microsoft.AspNetCore.Http;
using Web.Api.Common.Dtos.Auth;

namespace Web.Api.Core.Interfaces.Auxiliar
{
    public interface IContextAccessor
    {
        UserAuthDataDto GetUserAuthData();
        HttpContext Context { get; }
    }
}
