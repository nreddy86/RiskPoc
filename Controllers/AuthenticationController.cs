using ARUP.Context;
using ARUP.Models;
using System.Linq;
using System.Web.Http;

namespace ARUP.Controllers
{
    [RoutePrefix("api/authentication")]
    public class AuthenticationController : ApiController
    {
        DataContext db = new DataContext();

        /// <summary>
        /// Validate the user
        /// </summary>
        /// <returns></returns>
        // POST: api/authentication/validateuser
        [HttpPost]
        [Route("validateuser")]
        public IHttpActionResult ValidateUser([FromBody]Users user)
        {
            var result = (from usr in db.Users where usr.Username == user.Username && usr.Password == user.Password select usr).FirstOrDefault();
            return Ok(result);
        }

        /// <summary>
        /// Validate the user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getuser")]
        public IHttpActionResult GetUser()
        {
            return Ok("success");
        }
    }
}
