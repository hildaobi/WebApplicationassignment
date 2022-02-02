using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationassignment.Controllers
{
    public class greetingController : ApiController
    {

        //POST api/greetingid
        public string Post()
        {
            return "Hello World";
        }
    }
}
