using ARUP.Context;
using ARUP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ARUP.Controllers
{
    public class DashboardController : ApiController
    {
        DataContext db = new DataContext();
        Guid riskL = Guid.Parse("B0520AF9-53FA-E911-A68B-D8CB8A2BA16E");
        Guid riskM = Guid.Parse("B1520AF9-53FA-E911-A68B-D8CB8A2BA16E");
        Guid riskH = Guid.Parse("B1520AF9-53FA-E911-A68B-D8CB8A2BA16E");

        // GET: api/Dashboard/GetCards
        [Route("api/dashboard/getcards")]
        public IHttpActionResult GetCards()
        {
            var risks = db.RegisterEntries;
            List<GrapghItem> grapghItems = new List<GrapghItem>();

            int hCount = risks.Where(x => x.HAndSRisk == "H").Count();
            int eCount = risks.Where(x => x.EnvironmentalRisk == "E").Count();
            int pCount = risks.Where(x => x.ProgrammeRisk == "P").Count();
            int oCount = risks.Where(x => x.OtherRisk == "O").Count();

            GrapghItem grapghT = new GrapghItem()
            {
                Title = "# of Risks",
                Value = risks.Count().ToString(),
                Percentage = "%",
                Color = "#FE8D89",
                CssClass = "",
                Low = risks.Where(x => x.RiskScoreIdM == riskL).Count(),
                Medium = risks.Where(x => x.RiskScoreIdM == riskM).Count(),
                High = risks.Where(x => x.RiskScoreIdM == riskH).Count()

            };
            GrapghItem grapghH = new GrapghItem()
            {
                Title = "Health & Safety Risks",
                Value = hCount.ToString(),
                Percentage = (hCount * 100 / risks.Count()).ToString() + "%",
                Color = "#3FA8D7",
                CssClass = "",
                Low = risks.Where(x => x.RiskScoreIdM == riskL && x.HAndSRisk == "H").Count(),
                Medium = risks.Where(x => x.RiskScoreIdM == riskM && x.HAndSRisk == "H").Count(),
                High = risks.Where(x => x.RiskScoreIdM == riskH && x.HAndSRisk == "H").Count()

            };

            GrapghItem grapghE = new GrapghItem()
            {
                Title = "Environmental Risks",
                Value = eCount.ToString(),
                Percentage = (eCount * 100 / risks.Count()).ToString() + "%",
                Color = "#7CBA4B",
                CssClass = "",
                Low = risks.Where(x => x.RiskScoreIdM == riskL && x.EnvironmentalRisk == "E").Count(),
                Medium = risks.Where(x => x.RiskScoreIdM == riskM && x.EnvironmentalRisk == "E").Count(),
                High = risks.Where(x => x.RiskScoreIdM == riskH && x.EnvironmentalRisk == "E").Count()

            };
            GrapghItem grapghP = new GrapghItem()
            {
                Title = "Programme Risks",
                Value = pCount.ToString(),
                Percentage = (pCount * 100 / risks.Count()).ToString() + "%",
                Color = "#7C509B",
                CssClass = "",
                Low = risks.Where(x => x.RiskScoreIdM == riskL && x.ProgrammeRisk == "P").Count(),
                Medium = risks.Where(x => x.RiskScoreIdM == riskM && x.ProgrammeRisk == "P").Count(),
                High = risks.Where(x => x.RiskScoreIdM == riskH && x.ProgrammeRisk == "P").Count()

            };
            GrapghItem grapghO = new GrapghItem()
            {
                Title = "Other Risks",
                Value = oCount.ToString(),
                Percentage = (oCount * 100 / risks.Count()).ToString() + "%",
                Color = "#757479",
                CssClass = "",
                Low = risks.Where(x => x.RiskScoreIdM == riskL && x.OtherRisk == "O").Count(),
                Medium = risks.Where(x => x.RiskScoreIdM == riskM && x.OtherRisk == "O").Count(),
                High = risks.Where(x => x.RiskScoreIdM == riskH && x.OtherRisk == "O").Count()

            };
            grapghItems.Add(grapghT);
            grapghItems.Add(grapghE);
            grapghItems.Add(grapghO);
            grapghItems.Add(grapghH);
            grapghItems.Add(grapghP);

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
            var risks = db.RegisterEntries;
            var results = risks.GroupBy(x => x.RiskScoreIdUm);
            List<GrapghItem> grapghItems = new List<GrapghItem>();

            foreach (var item in results)
            {
                var riskStatus = db.RiskScores.Find(item.Key);
                GrapghItem grapgh = new GrapghItem()
                {
                    Title = riskStatus.Name,
                    Value = item.Count().ToString(),
                    Percentage = (item.Count() * 100 / risks.Count()).ToString() + "%",
                    Color = GetColour(riskStatus.Code),
                    CssClass = "",
                    Low = risks.Where(x => x.RiskScoreIdM == riskL).Count(),
                    Medium = risks.Where(x => x.RiskScoreIdM == riskM).Count(),
                    High = risks.Where(x => x.RiskScoreIdM == riskH).Count()

                };

                grapghItems.Add(grapgh);
            }

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
            var risks = db.RegisterEntries;
            var results = risks.GroupBy(x => x.RiskStatusId);
            List<GrapghItem> grapghItems = new List<GrapghItem>();

            foreach (var item in results)
            {
                var riskStatus = db.RiskStatus.Find(item.Key);
                GrapghItem grapgh = new GrapghItem()
                {
                    Title = riskStatus.Name,
                    Value = item.Count().ToString(),
                    Percentage = (item.Count() * 100 / risks.Count()).ToString() + "%",
                    Color = GetColour(riskStatus.Name),
                    CssClass = "",
                    Low = risks.Where(x => x.RiskScoreIdM == riskL && x.RiskStatusId == item.Key).Count(),
                    Medium = risks.Where(x => x.RiskScoreIdM == riskM && x.RiskStatusId == item.Key).Count(),
                    High = risks.Where(x => x.RiskScoreIdM == riskH && x.RiskStatusId == item.Key).Count()

                };

                grapghItems.Add(grapgh);
            }

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
            var risks = db.RegisterEntries;
            var results = risks.GroupBy(x => x.ProjectId);
            List<GrapghItem> grapghItems = new List<GrapghItem>();

            foreach (var item in results)
            {
                var riskStatus = db.Projects.Find(item.Key);
                GrapghItem grapgh = new GrapghItem()
                {
                    Title = riskStatus.Title,
                    Value = item.Count().ToString(),
                    Percentage = (item.Count() * 100 / risks.Count()).ToString() + "%",
                    Color = string.Empty,
                    CssClass = "",
                    Low = risks.Where(x => x.RiskScoreIdM == riskL && x.ProjectId == item.Key).Count(),
                    Medium = risks.Where(x => x.RiskScoreIdM == riskM && x.ProjectId == item.Key).Count(),
                    High = risks.Where(x => x.RiskScoreIdM == riskH && x.ProjectId == item.Key).Count()

                };

                grapghItems.Add(grapgh);
            }
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
            var risks = db.RegisterEntries;
            var results = risks.GroupBy(x => x.DisciplineId);
            List<GrapghItem> grapghItems = new List<GrapghItem>();

            foreach (var item in results)
            {
                var riskStatus = db.DisciplineList.Find(item.Key);
                GrapghItem grapgh = new GrapghItem()
                {
                    Title = riskStatus.Code,
                    Value = item.Count().ToString(),
                    Percentage = (item.Count() * 100 / risks.Count()).ToString() + "%",
                    Color = string.Empty,
                    CssClass = "",
                    Low = risks.Where(x => x.RiskScoreIdM == riskL && x.DisciplineId == item.Key).Count(),
                    Medium = risks.Where(x => x.RiskScoreIdM == riskM && x.DisciplineId == item.Key).Count(),
                    High = risks.Where(x => x.RiskScoreIdM == riskH && x.DisciplineId == item.Key).Count()

                };

                grapghItems.Add(grapgh);
            }

            return Ok(grapghItems);
        }

        private string GetColour(string risk)
        {
            if (risk == "L")
            {
                return "#F69F02";
            }
            else if (risk == "M")
            {
                return "#CD4026";
            }
            else if (risk == "H")
            {
                return "#7BBB4B";
            }
            else if (risk == "ACTIVE")
            {
                return "#CD4026";
            }
            else if (risk == "RESOLVED")
            {
                return "#7BBB4B";
            }
            else if (risk == "CONTINUED")
            {
                return "#FE8D89";
            }

            return string.Empty;
        }
    }
}
