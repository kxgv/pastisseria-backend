using Microsoft.AspNetCore.Http;

namespace Web.Api.Core.Interfaces.Auxiliar
{
    public interface IContextAccessor
    {
        //UserAuthData GetUserAuthData();
        //void AppendCookieContext(string name, string value,CookieOptions options);
        HttpContext Context { get; }
    }
}
