using BalticMarinasBuySellWS.Models;
using BalticMarinasBuySellWS.Repositories;
using BalticMarinasBuySellWS.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BalticMarinasBuySellWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldItemsController : ControllerBase
    {
        // GET api/solditems
        [HttpGet]
        public IEnumerable<SoldItem> GetAll()
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            return repository.GetAllSoldItems();
        }

        // GET api/solditems/5
        [HttpGet("{id}")]
        public SoldItem GetById(int id)
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            return repository.GetSoldItemById(id);
        }

        // GET api/solditems/users/2
        [HttpGet("users/{id}")]
        public IEnumerable<SoldItem> GetAllByUserId(int id)
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            return repository.GetAllSoldItemsByUserId(id);
        }

        // POST api/solditems/
        [HttpPost]
        public void Post([FromBody] SoldItem soldItem)
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            repository.CreateSoldItem(soldItem);
        }

        // GET api/solditems/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ISoldItemRepository repository = HttpContext.RequestServices.GetService(typeof(SoldItemRepository)) as SoldItemRepository;
            repository.DeleteSoldItemById(id);
        }
    }
}