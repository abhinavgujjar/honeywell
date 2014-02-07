using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoker
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.CricketRankingServiceClient client = new ServiceReference1.CricketRankingServiceClient();
            var rankings = client.GetAllRankings();

            Console.ReadLine();

        }
    }
}
