using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LORTool
{
    class Program
    {

        public static List<Prof> profList = new List<Prof>();
        static void Main(string[] args)
        {

            using (var reader = new StreamReader(@"C:\Users\110116067\Downloads\profs.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Prof p = new Prof();
                    Console.WriteLine(values[0]);
                    p.Name = values[0];
                    p.score = Convert.ToInt32(values[1]);
                    profList.Add(p);
                }
            }


        }
    }

    public class Prof
    {
        public string Name { get; set; }
        public int score { get; set; }
    }
}
