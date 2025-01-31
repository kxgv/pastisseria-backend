using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Common.Dtos.Auth;

namespace Web.Api.Core.Interfaces
{
    public interface IUsersService
    {
        public async Task<UserAuthDataDto> GetUserInfo(string userId);
    }
}
