using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Pharmacy.Data.Models;
using Pharmacy.Data.Repositories;

namespace Pharmacy.Api.Controllers
{
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        DicCanBoRepository provider = null;
        DicPhongBanRepository provider2 = null;

        //public ValuesController(DicCanBoProvider _context, DicPhongBanProvider phongBanProvider)
        //{
        //    provider = _context;
        //    provider2 = phongBanProvider;
        //}
        public ValuesController(IConfiguration configuration)
        {
            provider = new DicCanBoRepository(configuration);
            provider2 = new DicPhongBanRepository(configuration);
        }
        // GET api/values
        [HttpGet]
        [MapToApiVersion("1.0")]
        public object Get()
        {
            return new { canbo = provider.GetAll().Take(5), phongban = provider2.GetAll().Take(5) };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [MapToApiVersion("2.0")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
