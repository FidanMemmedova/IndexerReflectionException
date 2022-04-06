using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:Send message by email");
            Console.WriteLine("2:Send message by sms");
            Console.WriteLine("0:Quit");
            int number = Int32.Parse(Console.ReadLine());
            EmailSender email = new EmailSender();
            SmsSender sms = new SmsSender();
            switch (number)
            {
                case 1:
                    Console.WriteLine("Emaile mesaj yazin : ");
                    email.SendMessage("salam");
                    break;
                case 2:
                    Console.WriteLine("Sms daxil edin");
                    sms.SendMessage("asdf");
                    break;
                case 0:
                    Console.WriteLine("Proqram sona catdi!");
                    break;
                default:
                    Console.WriteLine("Bele secim yoxdur!");
                    break;

            }
        }
    }
}
