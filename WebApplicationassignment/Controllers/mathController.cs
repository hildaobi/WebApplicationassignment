using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationassignment.Controllers
{
    public class mathController : ApiController
    {
        //GET /api/math/id
        public int GET(int id) 
        {
            return id + 10;
           // return id - 10;
           // return id * 10;
            //return id / 10;
        }
    }
}
