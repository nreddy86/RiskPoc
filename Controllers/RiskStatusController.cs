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
    public class RiskStatusController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/RiskStatus
        public IQueryable<RiskStatus> GetRiskStatus()
        {
            return db.RiskStatus;
        }

        // GET: api/RiskStatus/5
        [ResponseType(typeof(RiskStatus))]
        public IHttpActionResult GetRiskStatus(Guid id)
        {
            RiskStatus riskStatus = db.RiskStatus.Find(id);
            if (riskStatus == null)
            {
                return NotFound();
            }

            return Ok(riskStatus);
        }

        // PUT: api/RiskStatus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRiskStatus(Guid id, RiskStatus riskStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != riskStatus.RiskStatusId)
            {
                return BadRequest();
            }

            db.Entry(riskStatus).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RiskStatusExists(id))
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

        // POST: api/RiskStatus
        [ResponseType(typeof(RiskStatus))]
        public IHttpActionResult PostRiskStatus(RiskStatus riskStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RiskStatus.Add(riskStatus);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = riskStatus.RiskStatusId }, riskStatus);
        }

        // DELETE: api/RiskStatus/5
        [ResponseType(typeof(RiskStatus))]
        public IHttpActionResult DeleteRiskStatus(Guid id)
        {
            RiskStatus riskStatus = db.RiskStatus.Find(id);
            if (riskStatus == null)
            {
                return NotFound();
            }

            db.RiskStatus.Remove(riskStatus);
            db.SaveChanges();

            return Ok(riskStatus);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RiskStatusExists(Guid id)
        {
            return db.RiskStatus.Count(e => e.RiskStatusId == id) > 0;
        }
    }
}