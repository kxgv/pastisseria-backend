using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Common.Dtos.Auth;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Services
{
    public class UserService :IUsersService
    {
        public UserService() { }

        public async Task<UserAuthDataDto> GetUserInfo(string userName)
        {
            var userAuthData = new UserAuthDataDto();
            return userAuthData;
        }
    }
}
