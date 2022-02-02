using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationassignment.Controllers
{
    public class addTenController : ApiController
    {
        //GET api/addTen/2
        public int GET(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}
