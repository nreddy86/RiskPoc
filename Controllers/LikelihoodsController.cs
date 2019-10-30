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
    public class LikelihoodsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Likelihoods
        public IQueryable<Likelihoods> GetLikelihoods()
        {
            return db.Likelihoods;
        }

        // GET: api/Likelihoods/5
        [ResponseType(typeof(Likelihoods))]
        public IHttpActionResult GetLikelihoods(Guid id)
        {
            Likelihoods likelihoods = db.Likelihoods.Find(id);
            if (likelihoods == null)
            {
                return NotFound();
            }

            return Ok(likelihoods);
        }

        // PUT: api/Likelihoods/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLikelihoods(Guid id, Likelihoods likelihoods)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != likelihoods.LikelihoodId)
            {
                return BadRequest();
            }

            db.Entry(likelihoods).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LikelihoodsExists(id))
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

        // POST: api/Likelihoods
        [ResponseType(typeof(Likelihoods))]
        public IHttpActionResult PostLikelihoods(Likelihoods likelihoods)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Likelihoods.Add(likelihoods);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = likelihoods.LikelihoodId }, likelihoods);
        }

        // DELETE: api/Likelihoods/5
        [ResponseType(typeof(Likelihoods))]
        public IHttpActionResult DeleteLikelihoods(Guid id)
        {
            Likelihoods likelihoods = db.Likelihoods.Find(id);
            if (likelihoods == null)
            {
                return NotFound();
            }

            db.Likelihoods.Remove(likelihoods);
            db.SaveChanges();

            return Ok(likelihoods);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LikelihoodsExists(Guid id)
        {
            return db.Likelihoods.Count(e => e.LikelihoodId == id) > 0;
        }
    }
}