using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCoreApi.Models;
using System.Linq.Dynamic.Core;

namespace MyCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPFController : ControllerBase
    {
        b248dbContext dc = new b248dbContext();

        //how filtering works 

        [Route("filter")]
        [HttpGet]
        public List<Studenttbl> Index(string name)
        {
            var res = from t in dc.Studenttbls
                      where t.Sname == name
                      select t;
            return res.ToList();
        }

        //how sorting works 
        [Route("sort")]
        [HttpGet]
        public List<Studenttbl> sortmethod(string columnname)
        {
            //if(columnname == "sname")
            //{
            //     var res = from t in dc.Studenttbls
            //               orderby t.Sname
            //               select t;
            //     return res.ToList();
            //}
            //if (columnname == "age")
            //{
            //     var res = from t in dc.Studenttbls
            //               orderby t.Age
            //               select t;
            //     return res.ToList();
            // }
            //else
            //{
            //     var res = from t in dc.Studenttbls
            //               select t;
            //     return res.ToList();
            // }

            var filteredCustomers = dc.Studenttbls.AsQueryable()
                .OrderBy(columnname)
                .ToList();
            return filteredCustomers.ToList();
        }

        //how paging works

        [HttpGet]
        [Route("paging")]
        public IList<Studenttbl> Searchrow(int pageNumber,int pageSize)
        {
            var item = dc.Studenttbls.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return item.ToList();   
        }

    }
}
