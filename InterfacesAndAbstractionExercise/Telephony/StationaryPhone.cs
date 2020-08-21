using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        


        public void Calling(string num)
        {
            if (!validateNumber(num))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Dialing... {num}");
            }
           
        }
        private bool validateNumber(string num)
        {
            return int.TryParse(num, out int n);
        }
    }
}
