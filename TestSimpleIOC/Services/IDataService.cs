using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSimpleIOC.Services
{
    public interface IDataService
    {
        List<string> GetStrings();
    }
}
