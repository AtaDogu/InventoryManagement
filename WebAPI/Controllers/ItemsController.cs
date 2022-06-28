using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _itemService.GetList();
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _itemService.Get(id);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Item item)
        {
            var result = _itemService.Add(item);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Item item)
        {
            var result = _itemService.Delete(item);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Item item)
        {
            var result = _itemService.Update(item);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
