﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace csaElectric
{
    using System.Net;
    using System.Net.Mail;
    using Model;

    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]EmailDetail emailDetail)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(emailDetail.SenderEmail);
            message.To.Add(new MailAddress("nomeshg@gmail.com"));
            message.Subject = "Customer Query";
            // message.IsBodyHtml = true; //to make message body as html  

            message.Body = emailDetail.GetEmailBody();
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("csaelectricbike@gmail.com", "qpbmnscvgowyqgau");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
    }
}
