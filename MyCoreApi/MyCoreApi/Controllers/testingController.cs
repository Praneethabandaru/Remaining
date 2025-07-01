using System.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCoreApi.Models;

namespace MyCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testingController : ControllerBase
    {
        b248dbContext dc = new b248dbContext();

        [HttpDelete]
        [Route("del")]
        public int Delete(int id)
        {
            var res = (from t in dc.Studenttbls
                       where t.Std == id
                       select t).FirstOrDefault();
            dc.Studenttbls.Remove(res);
            int i = dc.SaveChanges();
            return i;
        }

        [HttpGet]
        [Route("ser")]
        public IActionResult Searchrow(int id) // Change return type to IActionResult
        {
            var res = (from t in dc.Studenttbls
                       where t.Std == id
                       select t).FirstOrDefault();

            if (res == null)
            {
                return NotFound(); // Return 404 response
            }
            else
            {
                return Ok(res); // Return 200 response with the result
            }
        }

        [HttpGet]
        [Route("gen")]
        public ActionResult<Studenttbl> Searchrowgen(int id)
        {
            var res = (from t in dc.Studenttbls
                       where t.Std == id
                       select t).FirstOrDefault();

            if (res == null)
            {
                return NotFound(); // Return 404 response
            }
            else
            {
                return Ok(res); // Return 200 response with the result
            }
        } 

        //how async await works

        //public async Task<List<Studenttbl>> ShowAll()
        //{
        //    var res = from t in dc.Studenttbls
        //               select t;
        //    return await res.ToListAsync();
        //}
    }
}
