using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Trainees.Data;
using Trainees.Data.Entities;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal;
using System.Collections;

namespace Trainees.Controllers
{
    [Route("api/[controller]")]
    public class TraineesController : Controller
    {
        public TraineesContext _context{get;set;}

        public TraineesController(TraineesContext trainseesContext){
            _context = trainseesContext;
        }

        //GET ALL
        //[HttpGet("getall",Name ="getall")]
        public IActionResult GetAll()
        {
            var clients = _context.Clients.ToList().Where(item => item.IsDelete != "1").Take(10);
            return Ok(clients.ToList());
        }

        [HttpGet("getID", Name = "getID")]
        public JsonResult GetID()
        {

            int count = _context.Clients.Last().ID;
            var data = new { ID = ++count };
            return new JsonResult( data );
        }

        [HttpPost("save", Name = "save")]
        public IActionResult SaveTrainee([FromBody]Trainee trainee)
        {
            if(!ModelState.IsValid){
                return BadRequest(new { Response = "Empty Object" });
            }
            else{
                Trainee t = trainee;
                t.IsDelete = "0";
                _context.Clients.Add(t);
                _context.SaveChanges(true);
                var clients = _context.Clients.ToList().Where(item => item.IsDelete != "1").Take(10); 
                return Ok(clients.ToList());
            }
        }
         
        //[HttpPut("deleteById", Name = "deleteById")]
        //public IActionResult DeleteById([FromBody]Trainee trainee){
        //    Trainee aTrainee = _context.Clients.Where(client => client.ID == trainee.ID).First();
        //    aTrainee.IsDelete = "1";
        //    _context.Clients.Update(aTrainee);
        //    _context.SaveChanges(true);
        //    IEnumerable<Trainee> clients= _context.Clients.ToList().Where(item => item.IsDelete != "1").Take(10);
        //    return Ok(clients.ToList());
        //}

        //[HttpPut("{objID}", Name = "deletebyid")]
        [HttpPut("{id}", Name = "deletebyid")]
        public IActionResult DeleteById(string objID)
        {
            Trainee aTrainee = _context.Clients.Where(client => client.ID == int.Parse(objID)).First();
            aTrainee.IsDelete = "1";
            _context.Clients.Update(aTrainee);
            _context.SaveChanges(true);
            IEnumerable<Trainee> clients = _context.Clients.ToList().Where(item => item.IsDelete != "1").Take(10);
            return Ok(clients.ToList());
        }

     

    }


}
