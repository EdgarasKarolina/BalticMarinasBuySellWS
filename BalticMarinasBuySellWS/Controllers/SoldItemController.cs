using BalticMarinasBuySellWS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BalticMarinasBuySellWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldItemController : ControllerBase
    {
        // GET api/solditem
        [HttpGet]
        public IEnumerable<SoldItem> GetAll()
        {
            SoldItemContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasBuySellWS.Models.SoldItemContext)) as SoldItemContext;
            return context.GetAllSoldItems();
        }

        // GET api/solditem/5
        [HttpGet("{id}")]
        public SoldItem GetById(int id)
        {
            SoldItemContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasBuySellWS.Models.SoldItemContext)) as SoldItemContext;
            return context.GetSoldItemById(id);
        }
    }
}