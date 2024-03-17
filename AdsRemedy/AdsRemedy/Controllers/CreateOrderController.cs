using AdsRemedy.DataLayer;
using AdsRemedy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdsRemedy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOrderController : ControllerBase
    {
        public readonly DBCreateOrder _dbcontext;

        public CreateOrderController(DBCreateOrder context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreateOrder>>> getAllCreateOrder()
        {
            if(_dbcontext.CreateOrders == null)
            {
                return NotFound();
            }
            return await _dbcontext.CreateOrders.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CreateOrder>> getCreateOrderById(int id)
        {
            var createorder = await _dbcontext.CreateOrders.FindAsync(id);

            if (createorder == null)
            {
                return NotFound();
            }

            return createorder;
        }


        [HttpPost]
        public async Task<ActionResult<CreateOrder>> postCreateOrder(CreateOrder createorder)
        {
            _dbcontext.CreateOrders.Add(createorder);
            await _dbcontext.SaveChangesAsync();
            return Ok("Create Order added successfully!!!");
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> putCreateOrder(int id, CreateOrder createorder)
        {
            if(id != createorder.CO_Id)
            {
                return BadRequest();
            }

            _dbcontext.Entry(createorder).State = EntityState.Modified;

            try
            {
                await _dbcontext.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                throw;
            }
            return Ok("Create Order updated successfully!!!");
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> deleteCreateOrder(int id)
        {
            if(_dbcontext.CreateOrders == null)
            {
                return NotFound();
            }

            var createorder = await _dbcontext.CreateOrders.FindAsync(id);

            if(createorder == null)
            {
                return NotFound();
            }

            _dbcontext.CreateOrders.Remove(createorder);
            await _dbcontext.SaveChangesAsync();

            return Ok("Create Order deleted successfully!!!");
        }
    }
}
