using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationassignment.Controllers
{
    public class squareController : ApiController
    {
        //GET api/square/2
        public int GET(int id)
        {
            int square = id * id;
            return square;
        }

    }
}
