﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedicalClinicWebApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabOrdersController : ControllerBase
    {
        // GET: api/<LabOrdersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value10" };
        }

        // GET api/<LabOrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LabOrdersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LabOrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LabOrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}