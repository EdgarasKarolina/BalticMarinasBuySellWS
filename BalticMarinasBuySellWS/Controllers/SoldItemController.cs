using BalticMarinasBuySellWS.Models;
using BalticMarinasBuySellWS.Repositories;
using BalticMarinasBuySellWS.Repositories.Interfaces;
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
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            return repository.GetAllSoldItems();
        }

        // GET api/solditem
        [HttpGet("user/{id}")]
        public IEnumerable<SoldItem> GetAllByUserId(int id)
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            return repository.GetAllSoldItemsByUserId(id);
        }

        // GET api/solditem/5
        [HttpGet("{id}")]
        public SoldItem GetById(int id)
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            return repository.GetSoldItemById(id);
        }

        // POST api/solditem/
        [HttpPost]
        public void Post([FromBody] SoldItem soldItem)
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            repository.CreateSoldItem(soldItem);
        }

        // GET api/solditem/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            repository.DeleteSoldItemById(id);
        }
    }
}