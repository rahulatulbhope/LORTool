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

            for (int i = 0; i < profList.Count; i++)
            {
                for (int j = 0; j < profList.Count; j++)
                {
                    for (int k = 0; k < profList.Count; k++)
                    {
                        if (profList[i].Name != profList[j].Name && profList[k].Name != profList[j].Name && profList[i].Name != profList[k].Name)
                        {
                            int score_temp = profList[i].score + profList[j].score + profList[k].score;

                        }
                    }
                }
            }

        }

        static Boolean nameeq(string name1, string name2, string name3)
        {
            if (name1 == name2 || name2 == name3 || name3 == name1)
            {
                return false;
            }
            else
                return true;
        }

        static Boolean no_check(int no1, int no2, int no3)
        {
            if (no1 == 0 || no2 == 0 || no3 == 0)
                return false;
            else
                return true;
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

