using Raiding.Models;
using System;
using Raiding.Engine;
using Raiding.Factory;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Raiding

{
    public class Program
    {
        static void Main(string[] args)
        {

            Engine.Engine er = new Engine.Engine();
            er.Run();
          
        }
    }
}
