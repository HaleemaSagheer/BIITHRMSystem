//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using BIITHRMSystem.Models;

//namespace BIITHRMSystem.Controllers
//{
//    public class ApplicantController : ApiController
//    {
//        HRMDB2Entities1 db = new HRMDB2Entities1();
//        [HttpGet]
//        public HttpResponseMessage AllApplicant()
//        {
//            //select *from user
//            try
//            {
//                var app = db.Applicants.OrderBy(b => b.id).ToList();
//                return Request.CreateResponse(HttpStatusCode.OK, app);

//            }
//            catch (Exception ex)
//            {
//                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//        [HttpPost]
//        public HttpResponseMessage AddApplicant(Applicant u)   // ya wala function value insert karnay ka liya bnaya or httpresppnsemesseage return type ha
//        {
//            try
//            {
//                //Insert Into User Table
//                var users = db.Applicants.Add(u);
//                db.SaveChanges();
//                return Request.CreateResponse(HttpStatusCode.OK, u.Fname+"  Added");
//            }
//            catch (Exception ex)
//            {
//                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//        [HttpPost]
//        public HttpResponseMessage UpdateApplicant(Applicant u)
//        {
//            try
//            {

//                var original = db.Applicants.Find(u.id);
//                if (original == null)
//                {
//                    return Request.CreateResponse(HttpStatusCode.NotFound, "No record found");
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

//        [HttpGet]
//        public HttpResponseMessage DeleteApplicant(int id)
//        {
//            try
//            {

//                var original = db.Applicants.Find(id);
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
//        public HttpResponseMessage SearchApplicant(string u)
//        {
//            try
//            {

//                var search = db.Applicants.Where(b => b.Fname == u).OrderBy(b => b.id).ToList();

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
//        [HttpGet]
//        public HttpResponseMessage Applicantprofile(int id)
//        {
//            var list = db.Applicants.Join(db.Educations, a => a.id, ed => ed.applicantid, (a, ed) => new { a = a, ed = ed }).
//                Join(db.Experiences, aed => aed.a.id, ex => ex.ApplicantID, (aed, ex) => new { aed, ex }).Where(a => a.aed.a.id == id);
//            return Request.CreateResponse(HttpStatusCode.OK, list);
//        }
//    }
//}