using bumShopSolution.Application.Common.System;
using bumShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace bumShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userSevice;

        public UsersController(IUserService userService)
        {
            _userSevice = userService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromForm]LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var resultToken = await _userSevice.Authencate(request);
            if (string.IsNullOrEmpty(resultToken))
                return BadRequest("Tài khoản hoặc mật khẩu không chính xác!");

            return Ok(new { token = resultToken });
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm]RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userSevice.Register(request);
            if (!string.IsNullOrEmpty(result))
                return BadRequest(result + ". Đăng ký không thành công!");

            return Ok();
        }
    }
}