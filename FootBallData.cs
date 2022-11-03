using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataMunging
{
    internal class FootBallData: Data
    {
        protected override Regex Rx { get => new Regex(@"(^\s)+ +(\d+).\s+(\w+) +(\s+) +(\d+) +(\d+) +(\d+) +(\d+) +(\d+) +(\s+)-+(\s+) +(\d+)"); }
        public override IDictionary<string, int> GetData(string filePath)
        {
            return base.LoadData(filePath, 3, 9, 12);
        }
    }
}
