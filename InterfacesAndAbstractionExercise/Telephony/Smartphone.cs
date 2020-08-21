using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public void Browsing(string webPage)
        {
            if (!validateWebPage(webPage))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {webPage}!");
            }
        }

        public void Calling(string num)
        {
            if (!validateNumber(num))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {num}");
            }
        }
        private bool validateNumber(string num)
        {
            return int.TryParse(num, out int n);
        }
        private bool validateWebPage(string page)
        {
            bool result = true;
            for (int i = 0; i < page.Length; i++)
            {
                if (char.IsDigit(page[i]))
                {
                    result = false;
                    
                }
            }
            return result;
        }
    }
}
