using Microsoft.AspNetCore.Mvc;
using DevExpress.Compatibility.System.Web;
using DevExpress.XtraReports.Web.ReportDesigner;
using Microsoft.AspNetCore.Authorization;

namespace Alaca.Crm.Server.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportingController : ControllerBase
    {
        public ReportingController()
        {

        }
        //[HttpGet("GetReportDesignerModel")]
        [Route("[action]", Name = "getReportDesignerModel")]
        public object GetReportDesignerModel(string reportUrl)
        {
            reportUrl = "MyReport";
            string modelJsonScript = new ReportDesignerClientSideModelGenerator(HttpContext.RequestServices)
                .GetJsonModelScript(reportUrl, null, "/DXXRD", "/DXXRDV", "/DXQB");
            return new JavaScriptSerializer().Deserialize<object>(modelJsonScript);

        }
    }
}
