using DataMunging;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new WeatherData();
            var dayNumber = data.GetData("Data/weather.dat").MinBy(x => x.Value).Key;
            Console.WriteLine($"Day number {dayNumber} is with the smallest temperature spread.");

            data = new FootBallData();
            var teamName = data.GetData("Data/football.dat").MinBy(x => x.Value).Key;
            Console.WriteLine($"Team {teamName} has the smallest difference in ‘for’ and ‘against’ goals.");
        }
    }
}