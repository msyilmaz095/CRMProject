using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        IPaymentMethodService _paymentMethodService;
        public PaymentMethodController(IPaymentMethodService paymentMethodService)
        {
            _paymentMethodService = paymentMethodService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _paymentMethodService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _paymentMethodService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(PaymentMethod data)
        {
            return Ok(await _paymentMethodService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(PaymentMethod data)
        {
            return Ok(await _paymentMethodService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _paymentMethodService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _paymentMethodService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
