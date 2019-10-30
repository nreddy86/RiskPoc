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
    public class LifecyclesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Lifecycles
        public IQueryable<Lifecycles> GetLifecycles()
        {
            return db.Lifecycles;
        }

        // GET: api/Lifecycles/5
        [ResponseType(typeof(Lifecycles))]
        public IHttpActionResult GetLifecycles(Guid id)
        {
            Lifecycles lifecycles = db.Lifecycles.Find(id);
            if (lifecycles == null)
            {
                return NotFound();
            }

            return Ok(lifecycles);
        }

        // PUT: api/Lifecycles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLifecycles(Guid id, Lifecycles lifecycles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lifecycles.LifecycleId)
            {
                return BadRequest();
            }

            db.Entry(lifecycles).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LifecyclesExists(id))
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

        // POST: api/Lifecycles
        [ResponseType(typeof(Lifecycles))]
        public IHttpActionResult PostLifecycles(Lifecycles lifecycles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Lifecycles.Add(lifecycles);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = lifecycles.LifecycleId }, lifecycles);
        }

        // DELETE: api/Lifecycles/5
        [ResponseType(typeof(Lifecycles))]
        public IHttpActionResult DeleteLifecycles(Guid id)
        {
            Lifecycles lifecycles = db.Lifecycles.Find(id);
            if (lifecycles == null)
            {
                return NotFound();
            }

            db.Lifecycles.Remove(lifecycles);
            db.SaveChanges();

            return Ok(lifecycles);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LifecyclesExists(Guid id)
        {
            return db.Lifecycles.Count(e => e.LifecycleId == id) > 0;
        }
    }
}