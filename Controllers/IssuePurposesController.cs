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
    public class IssuePurposesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/IssuePurposes
        public IQueryable<IssuePurposes> GetIssuePurposes()
        {
            return db.IssuePurposes;
        }

        // GET: api/IssuePurposes/5
        [ResponseType(typeof(IssuePurposes))]
        public IHttpActionResult GetIssuePurposes(Guid id)
        {
            IssuePurposes issuePurposes = db.IssuePurposes.Find(id);
            if (issuePurposes == null)
            {
                return NotFound();
            }

            return Ok(issuePurposes);
        }

        // PUT: api/IssuePurposes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIssuePurposes(Guid id, IssuePurposes issuePurposes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != issuePurposes.IssueId)
            {
                return BadRequest();
            }

            db.Entry(issuePurposes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IssuePurposesExists(id))
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

        // POST: api/IssuePurposes
        [ResponseType(typeof(IssuePurposes))]
        public IHttpActionResult PostIssuePurposes(IssuePurposes issuePurposes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.IssuePurposes.Add(issuePurposes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = issuePurposes.IssueId }, issuePurposes);
        }

        // DELETE: api/IssuePurposes/5
        [ResponseType(typeof(IssuePurposes))]
        public IHttpActionResult DeleteIssuePurposes(Guid id)
        {
            IssuePurposes issuePurposes = db.IssuePurposes.Find(id);
            if (issuePurposes == null)
            {
                return NotFound();
            }

            db.IssuePurposes.Remove(issuePurposes);
            db.SaveChanges();

            return Ok(issuePurposes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IssuePurposesExists(Guid id)
        {
            return db.IssuePurposes.Count(e => e.IssueId == id) > 0;
        }
    }
}