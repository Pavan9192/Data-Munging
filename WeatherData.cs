using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataMunging
{
    internal class WeatherData: Data
    {
        protected override Regex Rx { get => new Regex(@"(^\s)+ +(\d+) +(\d+) +(\d+)"); }

        public override IDictionary<string, int> GetData(string filePath)
        {
            return base.LoadData(filePath, 2,3,4);
        }
    }
}
