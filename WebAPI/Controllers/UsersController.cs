using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getclaims")]
        public IActionResult GetClaims(User user)
        {
            var result = _userService.GetClaims(user);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbymail")]
        public IActionResult GetByMail(string mail)
        {
            var result = _userService.GetByMail(mail);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
