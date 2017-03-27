using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Use *.Net.Mail library to allow for SMTP Mailer
using System.Net.Mail;
//<summary>
//Summary description for clsBusinessLayer
/**************************************************
 * The purpose of this class is to automatically generate
 * and send an email to Admin users if an unauthorized user
 * attempts to login to the ACIT Payroll System.
 **************************************************/
//</summary>
public class clsBusinessLayer
{
    // boolean method to decide if an email should be sent
    // Declare variables
    public static bool SendEmail
        (
            string Sender, 
            string Recipient, 
            string bcc, 
            string cc,
            string Subject, 
            string Body
        )
    {
        // Try/Catch statement for sending emails.
        try
        {
            // Establishes a new email message called "MyMailMessage".
            MailMessage MyMailMessage = new MailMessage();

            // Establishes the sender of the email
            MyMailMessage.From = new MailAddress(Sender);

            // Establishes the recipient of the email.
            MyMailMessage.To.Add(new MailAddress(Recipient));

            // If statement to decipher if bcc variable is populated or empty.
            if (bcc != null && bcc != string.Empty)
            {
                // If empty, adds data to the bcc variable.
                MyMailMessage.Bcc.Add(new MailAddress(bcc));
            }

            // If statement to decipher if cc variable is populated or empty.
            if (cc != null && cc != string.Empty)
            {
                // If empty, adds data to the cc variable.
                MyMailMessage.CC.Add(new MailAddress(cc));
            }

            // Populates the subject line of the email message. 
            MyMailMessage.Subject = Subject;

            // Populates the body of the email message.
            MyMailMessage.Body = Body;

            // Establishes the email as an HTML document. 
            MyMailMessage.IsBodyHtml = true;

            // Sets the email priority to normal.
            MyMailMessage.Priority = MailPriority.Normal;

            // Establishes SMTP client to use local port settings.
            SmtpClient MySmtpClient = new SmtpClient("localhost");
            //SMTP Port = 25;
            //Generic IP host = "127.0.0.1";

            // Sends email
            MySmtpClient.Send(MyMailMessage);

            // Returns true to the boolean method for a sent email. 
            return true;
        }
        catch (Exception ex)
        {
            // Returns false to boolean statement if an email cannot be sent.
            return false;
        }
    }

	public clsBusinessLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}