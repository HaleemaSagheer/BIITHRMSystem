//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using BIITHRMSystem.Models;

//namespace BIITHRMSystem.Controllers
//{
//    public class ApplyController : ApiController
//    {
//        HRMDB2Entities db = new HRMDB2Entities();
//        [HttpPost]
//        public HttpResponseMessage Apply(Apply A)
//        {
//            try
//            {
//                db.Applies.Add(A);
//                db.SaveChanges();
//                return Request.CreateResponse(HttpStatusCode.OK, A);
//            }
//            catch
//            {
//                return Request.CreateResponse(HttpStatusCode.InternalServerError);
//            }
//        }
//    }
//}