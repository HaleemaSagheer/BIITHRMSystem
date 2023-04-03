//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using BIITHRMSystem.Models;

//namespace BIITHRMSystem.Controllers
//{
//    public class JobController : ApiController
//    {
//        HRMDB2Entities db = new HRMDB2Entities();

//        [HttpGet]
//        public HttpResponseMessage JobGet()
//        {
//            //select *from user
//            try
//            {
//                var app = db.Jobs.OrderBy(b => b.j_id).ToList();
//                return Request.CreateResponse(HttpStatusCode.OK, app);

//            }
//            catch (Exception ex)
//            {
//                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }
//        [HttpPost]
//        public HttpResponseMessage JobPost(Job u)   // ya wala function value insert karnay ka liya bnaya or httpresppnsemesseage return type ha
//        {
//            try
//            {
//                //Insert Into User Table
//                var users = db.Jobs.Add(u);
//                db.SaveChanges();
//                return Request.CreateResponse(HttpStatusCode.OK, u.j_title + " " + "Record Inserted");
//            }
//            catch (Exception ex)
//            {
//                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//        [HttpPut]
//        public HttpResponseMessage UpdateJob(Job u)
//        {
//            try
//            {

//                var original = db.Jobs.Find(u.j_id);
//                if (original == null)
//                {
//                    return Request.CreateResponse(HttpStatusCode.NotFound, "No record updated");
//                }
//                db.Entry(original).CurrentValues.SetValues(u);
//                db.SaveChanges();
//                return Request.CreateResponse(HttpStatusCode.OK, "Record Updated");

//            }
//            catch (Exception ex)
//            {
//                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//        [HttpDelete]
//        public HttpResponseMessage DeleteJob(int j_id)
//        {
//            try
//            {

//                var original = db.Jobs.Find(j_id);
//                if (original == null)
//                {
//                    return Request.CreateResponse(HttpStatusCode.NotFound, "No Record Found");
//                }
//                db.Entry(original).State = System.Data.Entity.EntityState.Deleted;
//                db.SaveChanges();
//                return Request.CreateResponse(HttpStatusCode.OK, "Record Deleted");

//            }
//            catch (Exception ex)
//            {
//                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }


//        [HttpGet]
//        public HttpResponseMessage SearchJob(string u)
//        {
//            try
//            {

//                var search = db.Jobs.Where(b => b.j_title == u).OrderBy(b => b.j_id).ToList();

//                if (search == null)
//                {
//                    return Request.CreateResponse(HttpStatusCode.NotFound, "Record Not Found");

//                }
//                return Request.CreateResponse(HttpStatusCode.OK, search);

//            }
//            catch (Exception ex)
//            {
//                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//    }
//}