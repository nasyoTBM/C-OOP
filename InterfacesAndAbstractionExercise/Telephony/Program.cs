using System;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] pages = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var num in numbers)
            {
                if (num.Length==7)
                {
                    StationaryPhone phone = new StationaryPhone();
                    phone.Calling(num);
                }
                else
                {
                    Smartphone iPhone = new Smartphone();
                    iPhone.Calling(num);
                }
            }
            foreach (var page in pages)
            {
                Smartphone iPhone = new Smartphone();
                iPhone.Browsing(page);
            }
        }
    }
}
