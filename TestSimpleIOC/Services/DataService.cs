using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSimpleIOC.Services
{
    class DataService : IDataService
    {
        public  List<string> GetStrings()
        {
            var retStrings = new List<string>();

            Random random = new Random();
            for (int i = 0; i<5;i++)
            {
                retStrings.Add(random.Next(1,100).ToString());
                    
            }
            return retStrings;
        }
    }
}
