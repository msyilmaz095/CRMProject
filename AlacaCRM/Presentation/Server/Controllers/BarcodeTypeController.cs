using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Alaca.Crm.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeTypeController : ControllerBase
    {
        IBarcodeTypeService _barcodeTypeService;
        public BarcodeTypeController(IBarcodeTypeService barcodeTypeService)
        {
            _barcodeTypeService = barcodeTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _barcodeTypeService.GetAllList();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _barcodeTypeService.GetById(id));
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(BarcodeType data)
        {
            return Ok(await _barcodeTypeService.Add(data));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(BarcodeType data)
        {
            return Ok(await _barcodeTypeService.Update(data));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = (await _barcodeTypeService.GetById(id)).Data;
            if (data != null)
            {
                var result = await _barcodeTypeService.Remove(data);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
