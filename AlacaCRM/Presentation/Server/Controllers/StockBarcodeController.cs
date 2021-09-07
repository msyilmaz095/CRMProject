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
    public class StockBarcodeController : ControllerBase
    {
        IStockBarcodeService _stockBarcodeService;
        public StockBarcodeController(IStockBarcodeService stockBarcodeService)
        {
            _stockBarcodeService = stockBarcodeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _stockBarcodeService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetByStockIdStockBarcode")]
        public async Task<IActionResult> GetByStockIdStockBarcode(Guid? StockId)
        {
            var data = await _stockBarcodeService.GetByStockIdStockBarcode(StockId);
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _stockBarcodeService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(StockBarcode data)
        {
            return Ok(await _stockBarcodeService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(StockBarcode data)
        {
            return Ok(await _stockBarcodeService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _stockBarcodeService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _stockBarcodeService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
