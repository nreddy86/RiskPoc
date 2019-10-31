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
                Value = "20",
                Color = "red",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Continue",
                Value = "30",
                Color = "red",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Resolved",
                Value = "80",
                Color = "red",
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
                Title = "Low Risk",
                Value = "10",
                Percentage = "40%",
                Color = "#7BBB4B",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Medium Risk",
                Value = "30",
                Percentage = "20%",
                Color = "#F69F02",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "High Risk",
                Value = "18",
                Color = "#CD4026",
                CssClass = ""

            };
          
            List<GrapghItem> grapghItems = new List<GrapghItem>();
            grapghItems.Add(grapgh1);
            grapghItems.Add(grapgh2);
            grapghItems.Add(grapgh3);
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
                Value = "20",
                Color = "red",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Continue1",
                Value = "30",
                Color = "red",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Resolved1",
                Value = "20",
                Color = "red",
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
                Value = "20",
                Color = "#CD4026",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Continue",
                Value = "30",
                Color = "#FE8D89",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Resolved",
                Value = "20",
                Color = "#7BBB4B",
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
                Value = "20",
                Color = "red",
                CssClass = "",
                Low = 10,
                Medium = 15,
                High = 8

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Dell",
                Value = "30",
                Color = "red",
                CssClass = "",
                Low = 12,
                Medium = 4,
                High = 8

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "HP",
                Value = "20",
                Color = "red",
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
                Value = "20",
                Color = "red",
                CssClass = "",
                Low = 10,
                Medium = 15,
                High = 8

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "ELEC",
                Value = "30",
                Color = "red",
                CssClass = "",
                Low = 12,
                Medium = 4,
                High = 8

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "ACOU",
                Value = "20",
                Color = "red",
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
