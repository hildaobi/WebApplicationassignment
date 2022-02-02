using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationassignment.Controllers
{
    public class GreetingidController : ApiController
    {
        //GET api/greeting/id
        public string  GET(int id) 
        {
            // creating a variable name message
            string message = "Greetings to" + " " + id + " "+ "people!";
            return message;
        }

    }
}
