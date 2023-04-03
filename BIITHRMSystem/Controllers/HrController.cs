using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BIITHRMSystem.Models;

namespace BIITHRMSystem.Controllers
{
    public class HrController : ApiController
    {
        // GET api/<controller>
        readonly HRMDB2Entities1 db = new HRMDB2Entities1();
        [HttpPost]
              public HttpResponseMessage JobPost(job_posts j)
        
        {
            try
            {
                db.job_posts.Add(j);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, j.job_title + " " + "Job Posted ");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}





