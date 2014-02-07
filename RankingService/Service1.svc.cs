using CricInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RankingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CricketRankingService : ICricketRankingService
    {
        public List<Ranking> GetAllRankings()
        {
            var rankings = new List<Ranking>()
            {
                 new Ranking(){ 
                     Country = "India", 
                     Rank = 4 },
                 new Ranking(){ Country ="Australia", Rank = 4 },
 new Ranking(){ Country ="England", Rank = 4 },
 new Ranking(){ Country ="Sri Lanka", Rank = 4 }

            };

            return rankings;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
