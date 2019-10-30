using ARUP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ARUP.Controllers
{
    public class DashboardController : ApiController
    {
        // GET: api/Dashboard/GetCards
        [Route("api/dashboard/getcards")]
        public IHttpActionResult GetCards()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "Active",
                value = "20",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Continue",
                value = "30",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Resolved",
                value = "80",
                Colour = "red",
                CssClass = ""

            };

            List<GrapghItem> grapghItems = new List<GrapghItem>();
            grapghItems.Add(grapgh1);
            grapghItems.Add(grapgh2);
            grapghItems.Add(grapgh3);
            return Ok(grapghItems);
        }

        /// <summary>
        /// Used to display second row left
        /// </summary>
        /// <returns></returns>
        // GET: api/Dashboard/GetLikeliHood
        [Route("api/dashboard/getriskratingbreakdown")]
        public IHttpActionResult GetRiskRatingBreakDown()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "Absolute Certainty",
                value = "10",
                Percentage = "40%",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Very Likely",
                value = "30",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Likely",
                value = "18",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh4 = new GrapghItem()
            {
                Title = "Unlikely",
                value = "20",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh5 = new GrapghItem()
            {
                Title = "Remote",
                value = "30",
                Colour = "red",
                CssClass = ""

            };

            List<GrapghItem> grapghItems = new List<GrapghItem>();
            grapghItems.Add(grapgh1);
            grapghItems.Add(grapgh2);
            grapghItems.Add(grapgh3);
            grapghItems.Add(grapgh4);
            grapghItems.Add(grapgh5);
            return Ok(grapghItems);
        }

        /// <summary>
        /// Used to display second row middle
        /// </summary>
        /// <returns></returns>
        // GET: api/Dashboard/GetHeatMap
        [Route("api/dashboard/getriskheatmap")]
        public IHttpActionResult GetRiskHeatMap()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "Active1",
                value = "20",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Continue1",
                value = "30",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Resolved1",
                value = "20",
                Colour = "red",
                CssClass = ""

            };

            List<GrapghItem> grapghItems = new List<GrapghItem>();
            grapghItems.Add(grapgh1);
            grapghItems.Add(grapgh2);
            grapghItems.Add(grapgh3);
            return Ok(grapghItems);
        }

        /// <summary>
        /// Used to display second row right side
        /// </summary>
        /// <returns></returns>

        // GET: api/Dashboard/GetHeatMap
        [Route("api/dashboard/getactionplanbreakdown")]
        public IHttpActionResult GetActionPlanBreakDown()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "Active",
                value = "20",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Continue",
                value = "30",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Resolved",
                value = "20",
                Colour = "red",
                CssClass = ""

            };

            List<GrapghItem> grapghItems = new List<GrapghItem>();
            grapghItems.Add(grapgh1);
            grapghItems.Add(grapgh2);
            grapghItems.Add(grapgh3);
            return Ok(grapghItems);
        }

        /// <summary>
        /// Used to display third row right side
        /// </summary>
        /// <returns></returns>
        // GET: api/Dashboard/GetSeverityStats
        [Route("api/dashboard/getprojectrisks")]
        public IHttpActionResult GetProjectRisks()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "Ritz",
                value = "20",
                Colour = "red",
                CssClass = "",
                Low = 10,
                Medium = 15,
                High = 8

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Dell",
                value = "30",
                Colour = "red",
                CssClass = "",
                Low = 12,
                Medium = 4,
                High = 8

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "HP",
                value = "20",
                Colour = "red",
                CssClass = "",
                Low = 2,
                Medium = 1,
                High = 3

            };

            List<GrapghItem> grapghItems = new List<GrapghItem>();
            grapghItems.Add(grapgh1);
            grapghItems.Add(grapgh2);
            grapghItems.Add(grapgh3);
            return Ok(grapghItems);

            return Ok(grapghItems);
        }

        /// <summary>
        /// used to display third row left
        /// </summary>
        /// <returns></returns>
        // GET: api/Dashboard/GetDisciplineStats
        [Route("api/dashboard/getdisciplinestats")]
        public IHttpActionResult GetDisciplineStats()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "GEN",
                value = "20",
                Colour = "red",
                CssClass = "",
                Low = 10,
                Medium = 15,
                High = 8

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "ELEC",
                value = "30",
                Colour = "red",
                CssClass = "",
                Low = 12,
                Medium = 4,
                High = 8

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "ACOU",
                value = "20",
                Colour = "red",
                CssClass = "",
                Low = 2,
                Medium = 1,
                High = 3

            };

            List<GrapghItem> grapghItems = new List<GrapghItem>();
            grapghItems.Add(grapgh1);
            grapghItems.Add(grapgh2);
            grapghItems.Add(grapgh3);
            return Ok(grapghItems);
        }
    }
}
