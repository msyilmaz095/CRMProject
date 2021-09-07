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
    public class StockBrandController : ControllerBase
    {
        IStockBrandService _stockBrandService;
        public StockBrandController(IStockBrandService stockBrandService)
        {
            _stockBrandService = stockBrandService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _stockBrandService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _stockBrandService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(StockBrand data)
        {
            return Ok(await _stockBrandService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(StockBrand data)
        {
            return Ok(await _stockBrandService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = (await _stockBrandService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _stockBrandService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
