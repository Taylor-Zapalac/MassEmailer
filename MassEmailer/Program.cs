using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEmailer
{
    class Program
    {
        // Replace what you need, then run.
        // emailBody - The body of your email
        // SMTPCLIENT - your relay address
        static void Main(string[] args)
        {
            Emailer emailer = new Emailer();
            String SMTPCLIENT = "insert your relay here";

            List<String> emailList = new List<string>();
            String emailBody = "";

            foreach (string email in emailList)
            {
                emailer.SendEmail("Subject", email, emailBody, SMTPCLIENT, "insertYourEmailAddress@test.net");
            }
        }
    }
}
