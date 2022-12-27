using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csaElectric.Model
{
    public class EmailDetail
    {
        public String Name { get; set; }

        public String SenderEmail { get; set; }

        public String  Subject { get; set; }

        public String Message { get; set; }

        public String GetEmailBody()
        {
            return $"Name: {Name}  \n\nSenderEmail: {SenderEmail} \n\nSubject: {Subject}\n\nMessage: {Message}";
        }
    }
}
