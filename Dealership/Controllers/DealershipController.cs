using System.Collections.Generic;
using System.Web.Http;
using Dealership.Data.Repositories;
using Dealership.Models;

namespace Dealership.Controllers
{
    public class DealershipController : ApiController
    {
        private readonly InventoryRepository _repository;
        private readonly Mechanic _mechanic;

        public DealershipController()
        {
            _repository = new InventoryRepository();
            _mechanic = new Mechanic();
        }

        [Route("inventory"), HttpGet]
        public List<Inventory> Get()
        {
            return _repository.GetAll();
        } 

        [Route("inventory/{id}"), HttpGet]
        public Inventory Get(int id)
        {
            return _repository.GetById(id);
        }

        [Route("inventory/actions/buy"), HttpPost]
        public Inventory Buy(Inventory inventory)
        {
            _repository.Buy(inventory);
            return inventory;
        }

        [Route("inventory/{id}/actions/sell"), HttpPost]
        public void Sell(int id)
        {
            _repository.Sell(id);
        }

        [Route("inventory/{id}/actions/repair"), HttpPost]
        public Inventory Repair(int id)
        {
            _repository.Repair(id);
            return _repository.GetById(id);

        }
    }
}
