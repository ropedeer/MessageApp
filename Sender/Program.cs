using System;
using System.ServiceModel;
using MessageWCF;
using Sender.ServiceReference1;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new Service1Client();
            var choise = "y";
            
            while (choise == "y")
            {
                Console.Clear();

                string title;
                string textInput;
                DateTime date;

                TypeMessage(out title, out textInput, out date);
                SaveMessage(title, textInput, date, proxy, ref choise);
            }

            Environment.Exit(0);
        }

        private static void SaveMessage(string title, string textInput, DateTime date, Service1Client proxy, ref string choise)
        {
            if (title != "" || textInput != "")
            {
                try
                {
                    var message = new MessageModel()
                    {
                        Title = title,
                        Body = textInput,
                        DateOfMessage = date
                    };

                    proxy.SaveMessage(message);
                    Console.WriteLine("\nMessage saved!");

                    Console.Write("\nTo send another one push [y], else push any button " + "> ");
                    choise = Console.ReadLine().ToLower();
                }
                catch (FaultException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("\nTitle or message body is missing, push any button to try again");
                Console.ReadKey();
            }
        }

        private static void TypeMessage(out string title, out string textInput, out DateTime date)
        {
            Console.WriteLine("Hello! Write your message below.");

            Console.Write("\nTitle: ");
            title = Console.ReadLine();

            Console.Write("\nText: ");
            textInput = Console.ReadLine();

            date = DateTime.Now;
        }
    }
}
