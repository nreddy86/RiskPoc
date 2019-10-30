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


        // GET: api/Dashboard/GetLikeliHood
        [Route("api/dashboard/getlikelihoodstats")]
        public IHttpActionResult GetLikeliHoodStats()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "Absolute Certainty",
                value = "10",
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

        // GET: api/Dashboard/GetSeverityStats
        [Route("api/dashboard/getseveritystats")]
        public IHttpActionResult GetSeverityStats()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "Fatality",
                value = "4",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Major Injury",
                value = "6",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Significant Injury",
                value = "10",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh4 = new GrapghItem()
            {
                Title = "Lost-Time Injury",
                value = "20",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh5 = new GrapghItem()
            {
                Title = "First Aid Case",
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

        // GET: api/Dashboard/GetCategoriesStats
        [Route("api/dashboard/getlifecyclessstats")]
        public IHttpActionResult GetLifecyclesStats()
        {
            GrapghItem grapgh1 = new GrapghItem()
            {
                Title = "Construction",
                value = "52",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh2 = new GrapghItem()
            {
                Title = "Maintenance",
                value = "42",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh3 = new GrapghItem()
            {
                Title = "Operation",
                value = "70",
                Colour = "red",
                CssClass = ""

            };
            GrapghItem grapgh4 = new GrapghItem()
            {
                Title = "Demolition",
                value = "10",
                Colour = "red",
                CssClass = ""

            };

            List<GrapghItem> grapghItems = new List<GrapghItem>();
            grapghItems.Add(grapgh1);
            grapghItems.Add(grapgh2);
            grapghItems.Add(grapgh3);
            grapghItems.Add(grapgh4);
            return Ok(grapghItems);
        }

        // GET: api/Dashboard/GetHeatMap
        [Route("api/dashboard/getheatmap")]
        public IHttpActionResult GetHeatMap()
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

        // GET: api/Dashboard/GetHeatMap
        [Route("api/dashboard/getprojectslifecyclestagestats")]
        public IHttpActionResult GetProjectsLifeCycleStageStats()
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

    }
}
