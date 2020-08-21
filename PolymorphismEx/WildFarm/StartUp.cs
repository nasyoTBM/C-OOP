using System;
using WildFarm.Models;
using WildFarm.Models.SubModels;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Models.Engine.Engine en = new Models.Engine.Engine();
            en.Run();

        }
    }
}
