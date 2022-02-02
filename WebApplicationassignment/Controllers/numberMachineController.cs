using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationassignment.Controllers
{
    public class numberMachineController : ApiController
    {
        //GET api/numberMachine/id
        public int Get(int id)
        {


            //creating variables
            { 
            return id + 10;
            return id - 10;
            return id* 10;
            return id / 10;
            }
        }
          
 
    }








