using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_WebAPI;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        MobileRepository objj;
        public MobileController()
        {
            objj = new MobileRepository();
        }

        // GET: api/<MobileController>
        [HttpGet]
        public IEnumerable<Mobile> Get()
        {
            return objj.Showall();
        }

        // GET api/<MobileController>/5
        [HttpGet("{MobileId}")]
        public IEnumerable<Mobile> Get(int MobileId)
        {
            return objj.GetById(MobileId);
        }

        // POST api/<MobileController>
        [HttpPost]
        public void Post([FromBody] Mobile obj)
        {
            objj.Inserting(obj);
        }

        // PUT api/<MobileController>/5
        [HttpPut("{Name}/{Model}")]
        public void Put(string Name,string Model)
        {
            objj.update(Name, Model);

        }


        // DELETE api/<MobileController>/5
        [HttpDelete("{MobileId}")]
        public void Delete(int MobileId)
        {
            objj.Delete(MobileId);
        }
    }
}
