using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SmsSender : MessageSender
    {
        public override void SendMessage(string sms)
        {
            Console.WriteLine($"\nNomrenize mesajiniz gonderildi!\n\nMesaji gonderdiyiniz email : {sms}");
        }
    }
}
