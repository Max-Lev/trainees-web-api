using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trainees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //List<string> list = new List<string>();

        ////GET ALL
        //[HttpGet("getall", Name = "getall")]
        //public List<string> GetAll()
        //{

        //    list.Add("max");
        //    list.Add("lev");
        //    return list;
        //}

        //[HttpGet("getbyid/{id}", Name = "getbyid")]
        ////[HttpGet("getbyid/{id}")]
        //public string GetByID(int id)
        //{
        //    return "xxx";
        //}
        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
