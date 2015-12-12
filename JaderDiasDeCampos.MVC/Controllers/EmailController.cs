using JaderDiasDeCampos.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JaderDiasDeCampos.MVC.Controllers
{
    public class EmailController : ApiController
    {

        // POST: api/Email
        public void Post([FromBody]EmailSender email)
        {
            email.Enviar();
        }


    }
}
