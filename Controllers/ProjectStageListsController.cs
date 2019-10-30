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
    public class ProjectStageListsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/ProjectStageLists
        public IQueryable<ProjectStageList> GetProjectStageList()
        {
            return db.ProjectStageList;
        }

        // GET: api/ProjectStageLists/5
        [ResponseType(typeof(ProjectStageList))]
        public IHttpActionResult GetProjectStageList(Guid id)
        {
            ProjectStageList projectStageList = db.ProjectStageList.Find(id);
            if (projectStageList == null)
            {
                return NotFound();
            }

            return Ok(projectStageList);
        }

        // PUT: api/ProjectStageLists/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProjectStageList(Guid id, ProjectStageList projectStageList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != projectStageList.ProjectStageId)
            {
                return BadRequest();
            }

            db.Entry(projectStageList).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectStageListExists(id))
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

        // POST: api/ProjectStageLists
        [ResponseType(typeof(ProjectStageList))]
        public IHttpActionResult PostProjectStageList(ProjectStageList projectStageList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProjectStageList.Add(projectStageList);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = projectStageList.ProjectStageId }, projectStageList);
        }

        // DELETE: api/ProjectStageLists/5
        [ResponseType(typeof(ProjectStageList))]
        public IHttpActionResult DeleteProjectStageList(Guid id)
        {
            ProjectStageList projectStageList = db.ProjectStageList.Find(id);
            if (projectStageList == null)
            {
                return NotFound();
            }

            db.ProjectStageList.Remove(projectStageList);
            db.SaveChanges();

            return Ok(projectStageList);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProjectStageListExists(Guid id)
        {
            return db.ProjectStageList.Count(e => e.ProjectStageId == id) > 0;
        }
    }
}