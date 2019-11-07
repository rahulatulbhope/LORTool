using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LORTool
{
    class Program
    {

        public static List<Prof> profList = new List<Prof>();
        public static List<ProfGrp> profGrps = new List<ProfGrp>();
        static void Main(string[] args)
        {
            int score_found = 0;
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
                    p.number = Convert.ToInt32(values[2]);
                    profList.Add(p);
                }
            }

            
        }

        

        
    }

    public class Prof
    {
        public string Name { get; set; }
        public int score { get; set; }
        public int number { get; set; }
    }

    public class ProfGrp
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public string Name3 { get; set; }


    }
}

