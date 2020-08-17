using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CustomerMastersController : ApiController
    {
        private FinanceDbEntities db = new FinanceDbEntities();

        //GET: api/CustomerMasters
        public IQueryable<CustomerMaster> GetCustomerMasters()
        {
            return db.CustomerMasters;
        }

        // GET: api/CustomerMasters/5
        //[ResponseType(typeof(CustomerMaster))]
        [HttpGet]
        public object GetCustomerMaster([FromUri] string username, string ans1, string ans2, string ans3)
        {
            var emps = db.proc_GetAllDetails(username, ans1, ans2, ans3);

            return emps;

        }

        // PUT: api/CustomerMasters/5
        [ResponseType(typeof(void))]
        public object PutCustomerMaster([FromUri]int id, string password, CustomerMaster c)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (id != CustomerMaster.)
            //{
            //    return badrequest();
            //}

            //db.Entry(customerMaster).State = EntityState.Modified;

            var emp = db.proc_UpdatePassword(id, password);
            db.SaveChanges();
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!CustomerMasterExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return emp;
        }

        // POST: api/CustomerMasters
        [ResponseType(typeof(CustomerMaster))]
        public IHttpActionResult PostCustomerMaster(CustomerMaster customerMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CustomerMasters.Add(customerMaster);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = customerMaster.id }, customerMaster);
        }

        // DELETE: api/CustomerMasters/5
        [ResponseType(typeof(CustomerMaster))]
        public IHttpActionResult DeleteCustomerMaster(int id)
        {
            CustomerMaster customerMaster = db.CustomerMasters.Find(id);
            if (customerMaster == null)
            {
                return NotFound();
            }

            db.CustomerMasters.Remove(customerMaster);
            db.SaveChanges();

            return Ok(customerMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerMasterExists(int id)
        {
            return db.CustomerMasters.Count(e => e.id == id) > 0;
        }
    }
}