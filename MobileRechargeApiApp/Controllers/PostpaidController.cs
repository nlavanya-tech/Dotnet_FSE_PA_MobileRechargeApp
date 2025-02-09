﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MobileRechargeApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostpaidController : ControllerBase
    {

        // GET: api/Postpaid
        [HttpGet]
        public IEnumerable<string> GetAllPostpaidRechargeDetails()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Postpaid/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Postpaid
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Postpaid/5
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
