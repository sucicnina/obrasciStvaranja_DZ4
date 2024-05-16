using Bilder_ZD1;
using System;

class Program
{
    public static void Main()
    {
        IMailConstructor mailConstructor = new MailConstructor();
        SMTP smtp = new SMTP(mailConstructor);
        smtp.SendNoReplyMail();
        smtp.SentMail();
    }
}