using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Leder.Models;

namespace Leder.Controllers
{
    public class Procurements1Controller : ApiController
    {
        private LederContext db = new LederContext();

        // GET: api/Procurements1
        public IQueryable<Procurement> GetProcurement()
        {
            return db.Procurement;
        }

        // GET: api/Procurements1/5
        [ResponseType(typeof(Procurement))]
        public IHttpActionResult GetProcurement(int id)
        {
            Procurement procurement = db.Procurement.Find(id);
            if (procurement == null)
            {
                return NotFound();
            }

            return Ok(procurement);
        }

        // PUT: api/Procurements1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProcurement(int id, Procurement procurement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != procurement.ProcurementId)
            {
                return BadRequest();
            }

            db.Entry(procurement).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcurementExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Procurements1
        [ResponseType(typeof(Procurement))]
        public IHttpActionResult PostProcurement(Procurement procurement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Procurement.Add(procurement);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = procurement.ProcurementId }, procurement);
        }

        // DELETE: api/Procurements1/5
        [ResponseType(typeof(Procurement))]
        public IHttpActionResult DeleteProcurement(int id)
        {
            Procurement procurement = db.Procurement.Find(id);
            if (procurement == null)
            {
                return NotFound();
            }

            db.Procurement.Remove(procurement);
            db.SaveChanges();

            return Ok(procurement);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProcurementExists(int id)
        {
            return db.Procurement.Count(e => e.ProcurementId == id) > 0;
        }
    }
}