using Microsoft.AspNetCore.Mvc;
using FirstBalzorServer.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstBalzorServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ForcasetController : ControllerBase
    {
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetAll()
        {
            var svc = new WeatherForecastService();

            return new OkObjectResult(await svc.GetForecastAsync(DateTime.Now)); 
        }
    }
}
