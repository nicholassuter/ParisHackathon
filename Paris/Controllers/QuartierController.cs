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
    public class QuartiersController : ApiController
    {
        public IHttpActionResult GetAllQuartiers()
        {
            QuartierRepository quartierRepository = new QuartierRepository();
            IEnumerable<Quartier> quartiers = quartierRepository.GetQuartiers();

            return Ok(quartiers);
        }

        public IHttpActionResult GetQuartiersByTerm(string term)
        {
            QuartierRepository quartierRepository = new QuartierRepository();
            IEnumerable<Quartier> quartiers = quartierRepository.GetQuartiersByTerm(term);

            return Ok(quartiers);
        }
    }
}
