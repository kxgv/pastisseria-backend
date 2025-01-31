using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Web.Api.Common.Dtos.Auth;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Interfaces.Auxiliar;
using Web.Api.Core.Services;

namespace Web.Api.Controllers {
    public class UsersController : BaseService, IUsersService
    {
        //private readonly IMapper _mapper;
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IUsersService _usersService;

        public UsersController(
            IContextAccessor contextAccessor,
            //IUnitOfWork unitOfWork,
            IActionResultTypeMapper mapper,
            IUsersService usersService
            ) : base(contextAccessor)
        {
            //_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            //_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _usersService = usersService;
        }

        [HttpGet("userId")]
        public async Task<IActionResult> GetUserAuthData(string userName)
        {
            var userInfo = await _usersService.GetUserInfo(userName);
            if (userInfo == null)
            {
                return NotFoundResult();
            }
            return Ok(userInfo);
        }

        public Task<UserAuthDataDto> GetUserInfo(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
