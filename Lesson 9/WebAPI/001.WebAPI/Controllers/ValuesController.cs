using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace _001.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController:Controller
    {
        //GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //POST api/values
        [HttpPost]
        //Invoke-RestMethod https://localhost:44326/api/values -Method POST -Body (@{value="Hello, ASP.NET Core!"} | ConvertTo-Json) -ContentType "application/json"
        public string Post([FromBody] string value)
        {
            return $"Value is got! {value}";
        }

        //PUT api/values/5
        //Invoke-RestMethod https://localhost:44326/api/values/1 -Method PUT -Body (@{value="Hello, ASP.NET Core!"} | ConvertTo-Json) -ContentType "application/json"
        [HttpPut("{id}")]
        public string Put(int id,[FromBody] string value)
        {
            return Convert.ToString(id);
        }


        //DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
