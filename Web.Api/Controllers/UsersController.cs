using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Web.Api.Core.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Security.Authentication;

//using Web.Api.Common.Helpers;
//using Web.Api.Models.Request;

namespace Web.Api.Controllers {
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly IMapper _mapper;
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IUsersService _usersService;

        public UsersController(
            //IContextAccessor contextAccessor,
            //IUnitOfWork unitOfWork,
            //IActionResultTypeMapper mapper,
            IUsersService usersService
            )
        {
            //_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            //_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _usersService = usersService;
        }

        [HttpGet("userId")]
        public async Task<IActionResult> GetUserAuthData(string userName)
        {
            var userInfo = await _usersService.GetUserInfo(userName);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }

    }
}
