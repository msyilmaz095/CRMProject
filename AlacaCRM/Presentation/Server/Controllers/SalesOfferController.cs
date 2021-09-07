using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOfferController : ControllerBase
    {
        ISalesOfferService _salesOfferService;
        public SalesOfferController(ISalesOfferService salesOfferService)
        {
            _salesOfferService = salesOfferService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _salesOfferService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetviewSalesOffers")]
        public async Task<IActionResult> GetviewSalesOffers()
        {
            var data = await _salesOfferService.GetviewSalesOffers();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _salesOfferService.GetById(id));
        }

        [HttpGet("GetByProjectIdSalesOffers")]
        public async Task<IActionResult> GetByProjectIdSalesOffers(Guid ProjectId)
        {
            return Ok(await _salesOfferService.GetByProjectIdSalesOffers(ProjectId));
        }

        [HttpGet("GetByDateBetweenviewSalesOffers")]
        public async Task<IActionResult> GetByDateBetweenviewSalesOffers(DateTime StartDate, DateTime EndDate)
        {
            var data = await _salesOfferService.GetByDateBetweenviewSalesOffers(StartDate, EndDate);
            return Ok(data);
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(SalesOffer data)
        {
            return Ok(await _salesOfferService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(SalesOffer data)
        {
            return Ok(await _salesOfferService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _salesOfferService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _salesOfferService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("SalesOfferInsert")]
        public async Task<IActionResult> SalesOfferInsert(SalesOfferDto dto)
        {
            return Ok(await _salesOfferService.AddSalesOffer(dto.data, dto.salesOfferLines));
        }

        [HttpPost("SalesOfferUpdate")]
        public async Task<IActionResult> SalesOfferUpdate(SalesOfferDto dto)
        {
            return Ok(await _salesOfferService.UpdateSalesOffer(dto.data, dto.salesOfferLines));
        }

        [HttpGet("GetOrderDescTop10viewSalesOffers")]
        public async Task<IActionResult> GetOrderDescTop10viewSalesOffers()
        {
            var data = await _salesOfferService.GetOrderDescTop10viewSalesOffers();
            return Ok(data);
        }
    }

    public class SalesOfferDto
    {
        public SalesOffer data { get; set; }
        public List<SalesOfferLine> salesOfferLines { get; set; }
    }
}
