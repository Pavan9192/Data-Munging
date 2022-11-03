using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataMunging
{
    internal abstract class Data
    {
        protected abstract Regex Rx { get;}
        public abstract IDictionary<string, int> GetData(string filePath);
        protected IDictionary<string, int> LoadData(string filePath, int key, int max, int min)
        {
            Dictionary<string, int> kvp = new Dictionary<string, int>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                MatchCollection matches = Rx.Matches(line);

                if (matches.Count > 0)
                {
                    GroupCollection groupCollection = matches[0].Groups;
                    kvp.Add(groupCollection[key].Value, Convert.ToInt32(groupCollection[max].Value) - Convert.ToInt32(groupCollection[min].Value));
                }
            }
            return kvp;
        }
    }
}
