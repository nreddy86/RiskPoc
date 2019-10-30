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
    public class SeveritiesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Severities
        public IQueryable<Severities> GetSeverities()
        {
            return db.Severities;
        }

        // GET: api/Severities/5
        [ResponseType(typeof(Severities))]
        public IHttpActionResult GetSeverities(Guid id)
        {
            Severities severities = db.Severities.Find(id);
            if (severities == null)
            {
                return NotFound();
            }

            return Ok(severities);
        }

        // PUT: api/Severities/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSeverities(Guid id, Severities severities)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != severities.SeverityId)
            {
                return BadRequest();
            }

            db.Entry(severities).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeveritiesExists(id))
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

        // POST: api/Severities
        [ResponseType(typeof(Severities))]
        public IHttpActionResult PostSeverities(Severities severities)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Severities.Add(severities);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = severities.SeverityId }, severities);
        }

        // DELETE: api/Severities/5
        [ResponseType(typeof(Severities))]
        public IHttpActionResult DeleteSeverities(Guid id)
        {
            Severities severities = db.Severities.Find(id);
            if (severities == null)
            {
                return NotFound();
            }

            db.Severities.Remove(severities);
            db.SaveChanges();

            return Ok(severities);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SeveritiesExists(Guid id)
        {
            return db.Severities.Count(e => e.SeverityId == id) > 0;
        }
    }
}