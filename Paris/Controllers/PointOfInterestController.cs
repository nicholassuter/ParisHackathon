using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Paris.Models;
using Paris.Repositories;

namespace Paris.Repositories
{
}

namespace Paris.Controllers
{
    public class PointOfInterestController : ApiController
    {
        public IHttpActionResult GetPointOfInterests(int QuartierId)
        {
            PoiRepository poiRepository = new PoiRepository();
            IEnumerable<PointOfInterest> pointOfInterests = poiRepository.GetPointOfInterestsByQuartierId(QuartierId);

            return Ok(pointOfInterests);
        }
    }
}
