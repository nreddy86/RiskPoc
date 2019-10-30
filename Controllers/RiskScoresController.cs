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
    public class RiskScoresController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/RiskScores
        public IQueryable<RiskScores> GetRiskScores()
        {
            return db.RiskScores;
        }

        // GET: api/RiskScores/5
        [ResponseType(typeof(RiskScores))]
        public IHttpActionResult GetRiskScores(Guid id)
        {
            RiskScores riskScores = db.RiskScores.Find(id);
            if (riskScores == null)
            {
                return NotFound();
            }

            return Ok(riskScores);
        }

        // PUT: api/RiskScores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRiskScores(Guid id, RiskScores riskScores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != riskScores.RiskScoreId)
            {
                return BadRequest();
            }

            db.Entry(riskScores).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RiskScoresExists(id))
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

        // POST: api/RiskScores
        [ResponseType(typeof(RiskScores))]
        public IHttpActionResult PostRiskScores(RiskScores riskScores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RiskScores.Add(riskScores);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = riskScores.RiskScoreId }, riskScores);
        }

        // DELETE: api/RiskScores/5
        [ResponseType(typeof(RiskScores))]
        public IHttpActionResult DeleteRiskScores(Guid id)
        {
            RiskScores riskScores = db.RiskScores.Find(id);
            if (riskScores == null)
            {
                return NotFound();
            }

            db.RiskScores.Remove(riskScores);
            db.SaveChanges();

            return Ok(riskScores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RiskScoresExists(Guid id)
        {
            return db.RiskScores.Count(e => e.RiskScoreId == id) > 0;
        }
    }
}