using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _orderService.GetList();
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _orderService.Get(id);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Order order)
        {
            var result = _orderService.Add(order);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Order order)
        {
            var result = _orderService.Delete(order);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Order order)
        {
            var result = _orderService.Update(order);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
