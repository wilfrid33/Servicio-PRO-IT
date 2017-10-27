using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using pi2.Models;

namespace pi2.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]
    public class PlatosController : ApiController
    {
        proyectoEntities bd = new proyectoEntities();

        public IEnumerable<platos> GetAll()
        {
            return bd.platos.ToList();
        }
    }
}
