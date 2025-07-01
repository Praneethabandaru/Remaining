//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace MyCoreApi.Controllers
//{
//    [Route("api/mycon")]
//    [ApiController]
//    [ApiVersion("1.0")] //query based versioning
//    [Route("api/{v:apiVersion}/mycon")] //url based versioning
//    public class VersionDemoController : ControllerBase
//    {
//        //using versioning the clients can get newer features without changing the existing url 
//        [HttpGet]
//        public string Demo()
//        {
//            return "First Version";
//        }
//    }

//    [Route("api/mycon")]
//    [ApiController]
//    [ApiVersion("2.0")]
//    [Route("api/{v:apiVersion}/mycon")]
//    public class VersionDemo1Controller : ControllerBase
//    {
//        //using versioning the clients can get newer features without changing the existing url 
//        [HttpGet]
//        public string Demo()
//        {
//            return "Second Version";
//        }
//    }
//}
