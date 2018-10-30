using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalticMarinasBuySellWS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BalticMarinasBuySellWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldItemController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<SoldItem> GetAll()
        {
            SoldItemContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasBuySellWS.Models.SoldItemContext)) as SoldItemContext;
            return context.GetAllSoldItems();
        }
    }
}