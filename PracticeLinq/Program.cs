using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> { "Super Smash Bros.", "Mario Party", "Mario Kart" };
            
            //videoGames.ForEach(name => Console.WriteLine(name));

            var VG = videoGames.OrderBy(name => name.Length);
            foreach (var name in videoGames)
            {
                Console.WriteLine(name);
            }

           //LINQ way
           //videoGames.OrderBy(name => name.Length).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
