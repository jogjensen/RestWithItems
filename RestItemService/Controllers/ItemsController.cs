using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return items;
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return items.Find(i=>i.Id==id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public void Post([FromBody] Item value)
        {
            items.Add(value);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item value)
        {
            Item item = Get(id);
            if (item !=null)
            {
                item.Id = value.Id;
                item.Name = value.Name;
                item.Quality = value.Quality;
                item.Quantity = value.Quantity;
            }
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Item item = Get(id);
            items.Remove(item);
        }


        private static readonly List<Item> items = new List<Item>()
        {
            new Item(1,"Bread","Low",33),
            new Item(2,"Bread","Middle",21),
            new Item(3,"Beer","low",70.5),
            new Item(4,"Soda","High",21.4),
            new Item(5,"Milk","Low",55.8)
        };

    }

    
}
