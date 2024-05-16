using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilder_ZD1
{
    public class SMTP
    {
        IMailConstructor mailConstructor;
        public SMTP(IMailConstructor mailConstructor)
        {
            this.mailConstructor = mailConstructor;
        }

        public void SendNoReplyMail()
        {
            Mail mail = mailConstructor.AddSubject("No Reply").AddContent("Hello World").Construct();
            Console.WriteLine($"Subject: {mail.Subject}");
            Console.WriteLine($"Content: {mail.Content}");

        }
        public void SentMail()
        {
            Mail mail = mailConstructor.AddSubject("Professor").AddContent("Exam Results").AddRecipient(".").AddAttachments("Table Results").Construct();
            Console.WriteLine($"Subject: {mail.Subject}");
            Console.WriteLine($"Content: {mail.Content}");
            Console.WriteLine($"Recipient: {mail.Recipient}");
            Console.WriteLine($"Attachments: {mail.Attachments}");
        }
    }
}
