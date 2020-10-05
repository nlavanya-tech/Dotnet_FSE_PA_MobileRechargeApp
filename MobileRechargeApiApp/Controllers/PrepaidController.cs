using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileRechargeApiApp.DataLayer.Context;
using MobileRechargeApiApp.Entities;
using MongoDB.Driver;

namespace MobileRechargeApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrepaidController : ControllerBase
    {
        private readonly IMongoDbContext _context;
        public PrepaidController(IMongoDbContext context)
        {
            _context = context;
        }

        // GET: api/Prepaid
        [HttpGet]
        public async Task<IEnumerable<Postpaid>> Get()
        {
            var teams = await _context.Postpaid.Find(postpaid => true).ToListAsync();
            return teams;
        }

        // GET: api/Prepaid/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Prepaid
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Prepaid/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
