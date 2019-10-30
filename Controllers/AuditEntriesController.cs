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
using ARUP.Context;
using ARUP.Models;

namespace ARUP.Controllers
{
    public class AuditEntriesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/AuditEntries
        public IQueryable<AuditEntries> GetAuditEntries()
        {
            return db.AuditEntries;
        }

        // GET: api/AuditEntries/5
        [ResponseType(typeof(AuditEntries))]
        public IHttpActionResult GetAuditEntries(Guid id)
        {
            AuditEntries auditEntries = db.AuditEntries.Find(id);
            if (auditEntries == null)
            {
                return NotFound();
            }

            return Ok(auditEntries);
        }

        // PUT: api/AuditEntries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAuditEntries(Guid id, AuditEntries auditEntries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != auditEntries.AuditEntryId)
            {
                return BadRequest();
            }

            db.Entry(auditEntries).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuditEntriesExists(id))
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

        // POST: api/AuditEntries
        [ResponseType(typeof(AuditEntries))]
        public IHttpActionResult PostAuditEntries(AuditEntries auditEntries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AuditEntries.Add(auditEntries);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = auditEntries.AuditEntryId }, auditEntries);
        }

        // DELETE: api/AuditEntries/5
        [ResponseType(typeof(AuditEntries))]
        public IHttpActionResult DeleteAuditEntries(Guid id)
        {
            AuditEntries auditEntries = db.AuditEntries.Find(id);
            if (auditEntries == null)
            {
                return NotFound();
            }

            db.AuditEntries.Remove(auditEntries);
            db.SaveChanges();

            return Ok(auditEntries);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AuditEntriesExists(Guid id)
        {
            return db.AuditEntries.Count(e => e.AuditEntryId == id) > 0;
        }
    }
}