using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance.Events
{
    public class MailService
    {
        public void OnViceoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail service :  Sending an email.." +e.Video.Title);
        }
    }
}
