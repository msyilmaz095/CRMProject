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
    public class SalesOfferLineController : ControllerBase
    {
        ISalesOfferLineService _salesOfferLineService;
        public SalesOfferLineController(ISalesOfferLineService salesOfferLineService)
        {
            _salesOfferLineService = salesOfferLineService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _salesOfferLineService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetBySalesOfferIdLines")]
        public async Task<IActionResult> GetBySalesOfferIdLines(Guid SalesOfferId)
        {
            var data = await _salesOfferLineService.GetBySalesOfferIdLines(SalesOfferId);
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _salesOfferLineService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(SalesOfferLine data)
        {
            return Ok(await _salesOfferLineService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(SalesOfferLine data)
        {
            return Ok(await _salesOfferLineService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _salesOfferLineService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _salesOfferLineService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
