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
    public class RegisterEntriesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/RegisterEntries
        public IQueryable<RegisterEntries> GetRegisterEntries()
        {
            return db.RegisterEntries;
        }

        // GET: api/RegisterEntries/5
        [ResponseType(typeof(RegisterEntries))]
        public IHttpActionResult GetRegisterEntries(Guid id)
        {
            RegisterEntries registerEntries = db.RegisterEntries.Find(id);
            if (registerEntries == null)
            {
                return NotFound();
            }

            return Ok(registerEntries);
        }

        // GET: api/RegisterEntriesAll/5
        [ResponseType(typeof(RegisterEntries))]
        public IHttpActionResult GetRegisterEntriesAll(Guid id)
        {
            List<RegisterEntries> registerEntries = db.RegisterEntries.Where(r => r.ProjectId.Equals(id)).ToList();
            if (registerEntries == null)
            {
                return NotFound();
            }

            return Ok(registerEntries);
        }

        // PUT: api/RegisterEntries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRegisterEntries(Guid id, RegisterEntries registerEntries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != registerEntries.RegisterEntryId)
            {
                return BadRequest();
            }

            db.Entry(registerEntries).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterEntriesExists(id))
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

        // POST: api/RegisterEntries
        [ResponseType(typeof(RegisterEntries))]
        public IHttpActionResult PostRegisterEntries(RegisterEntries registerEntries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RegisterEntries.Add(registerEntries);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = registerEntries.RegisterEntryId }, registerEntries);
        }

        // DELETE: api/RegisterEntries/5
        [ResponseType(typeof(RegisterEntries))]
        public IHttpActionResult DeleteRegisterEntries(Guid id)
        {
            RegisterEntries registerEntries = db.RegisterEntries.Find(id);
            if (registerEntries == null)
            {
                return NotFound();
            }

            db.RegisterEntries.Remove(registerEntries);
            db.SaveChanges();

            return Ok(registerEntries);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegisterEntriesExists(Guid id)
        {
            return db.RegisterEntries.Count(e => e.RegisterEntryId == id) > 0;
        }
    }
}