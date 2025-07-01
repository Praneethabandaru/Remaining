using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCoreApi.Models;

namespace MyCoreApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        b248dbContext ob = new b248dbContext();
        string[] mystudents = 
        {
             "Prani", "Navi","Rohi","Guddu","Orthodox","Rowdy"     
        };

        string[] Countries =
        {
            "India", "Japan", "Singapore", "Swiz"
        };

        [Route("api/hello/st")]
        [HttpGet]
        public string[] GetStudents()
        {
            return mystudents;
        }

        [Route("api/hello/coun")]
        [HttpGet]
        public string[] GetCountries()
        {
            return Countries;
        }

        //[Produces("application/xml")]
        [Route("api/getstudents")]
        [HttpGet]
        public List<Studenttbl> getstudents()
        {
            var res =  from t in ob.Studenttbls
                       select t;
            return res.ToList();
        }

        [Route("api/getstudentsbyid")]
        [HttpGet]
        public List<Studenttbl> getstudentsbyid(int id)
        {
            var res = from t in ob.Studenttbls
                      where t.Std == id
                      select t;
            return res.ToList();
        }

        [Route("api/addstudents")]
        [HttpPost]
        public string PostStudents([FromQuery]Studenttbl st)
        {
            ob.Studenttbls.Add(st);
            int res = ob.SaveChanges();
            return "Total Records Inserted: " + res;
        }

        [Route("api/updatestudents")]
        [HttpPut]
        public string updatestudents(Studenttbl st)
        {
            var res = ob.Studenttbls.FirstOrDefault(x => x.Std == st.Std);
            if (res != null)
            {
                res.Sname = st.Sname;
                res.Age = st.Age;
                ob.SaveChanges();
                return "Record Updated Successfully";
            }
            else
            {
                return "Record Not Found";
            }
        }

        [Route("api/deletestudents")]
        [HttpDelete]
        public string DeleteStudents(int id)
        {
            var res = ob.Studenttbls.FirstOrDefault(x => x.Std == id);
            if (res != null)
            {
                ob.Studenttbls.Remove(res);
                ob.SaveChanges();
                return "Record Deleted Successfully";
            }
            else
            {
                return "Record Not Found";
            }
        }
    }
}
