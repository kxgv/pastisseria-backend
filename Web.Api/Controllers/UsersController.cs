using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
//using Web.Api.Core.Services;

namespace Web.Api.Controllers {
    public class UsersController //: BaseService, IRejectionService
    {
        //private readonly IMapper _mapper;
        //private readonly IUnitOfWork _unitOfWork;

        //public UsersController(
        //    IHttpContextAccessor contextAccessor,
        //    IUnitOfWork unitOfWork,
        //    IActionResultTypeMapper mapper
        //    )  : base(contextAccessor)
        //{
        //    _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        //    _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        //}

        //[HttpGet("userId")]
        //public async Task<IActionResult> GetUserInfo(int userId)
        //{
        //    var userInfo = await _userService.GetUserInfo(userId);
        //    if (userInfo == null)
        //    {
        //        return NotFoundResult(); 
        //    }
        //    return Ok(userInfo); 
        //}
    }
}
