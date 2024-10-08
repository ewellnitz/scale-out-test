﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;

namespace ScaleOutTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            WebApiConfig.Log.Add("ValuesController::Get");
            return WebApiConfig.Log.ToArray();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
