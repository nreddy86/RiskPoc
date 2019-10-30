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
    public class AuditsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Audits
        public IQueryable<Audit> GetAudit()
        {
            return db.Audit;
        }

        // GET: api/Audits/5
        [ResponseType(typeof(Audit))]
        public IHttpActionResult GetAudit(Guid id)
        {
            Audit audit = db.Audit.Find(id);
            if (audit == null)
            {
                return NotFound();
            }

            return Ok(audit);
        }

        // PUT: api/Audits/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAudit(Guid id, Audit audit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != audit.AuditId)
            {
                return BadRequest();
            }

            db.Entry(audit).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuditExists(id))
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

        // POST: api/Audits
        [ResponseType(typeof(Audit))]
        public IHttpActionResult PostAudit(Audit audit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Audit.Add(audit);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = audit.AuditId }, audit);
        }

        // DELETE: api/Audits/5
        [ResponseType(typeof(Audit))]
        public IHttpActionResult DeleteAudit(Guid id)
        {
            Audit audit = db.Audit.Find(id);
            if (audit == null)
            {
                return NotFound();
            }

            db.Audit.Remove(audit);
            db.SaveChanges();

            return Ok(audit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AuditExists(Guid id)
        {
            return db.Audit.Count(e => e.AuditId == id) > 0;
        }
    }
}