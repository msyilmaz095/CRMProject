using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOfferStatuController : ControllerBase
    {
        ISalesOfferStatuService _salesOfferStatuService;
        public SalesOfferStatuController(ISalesOfferStatuService salesOfferStatuService)
        {
            _salesOfferStatuService = salesOfferStatuService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _salesOfferStatuService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(byte id)
        {
            return Ok(await _salesOfferStatuService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(SalesOfferStatu data)
        {
            return Ok(await _salesOfferStatuService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(SalesOfferStatu data)
        {
            return Ok(await _salesOfferStatuService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(byte id)
        {
            var data = (await _salesOfferStatuService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _salesOfferStatuService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
