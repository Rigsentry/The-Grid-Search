using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_Grid_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> grid = new List<string>();
            //grid.Add("7283455864");
            //grid.Add("6731158619");
            //grid.Add("8988242643");
            //grid.Add("3830589324");
            //grid.Add("2229505813");
            //grid.Add("5633845374");
            //grid.Add("6473530293");
            //grid.Add("7053106601");
            //grid.Add("0834282956");
            //grid.Add("4607924137");
            //List<string> patternGrid = new List<string>();
            //patternGrid.Add("9505");
            //patternGrid.Add("3845");
            //patternGrid.Add("3530");

            List<string> grid = new List<string>();
            grid.Add("400453592126560");
            grid.Add("114213133098692");
            grid.Add("474386082879648");
            grid.Add("522356951189169");
            grid.Add("887109450487496");
            grid.Add("252802633388782");
            grid.Add("502771484966748");
            grid.Add("075975207693780");
            grid.Add("511799789562806");
            grid.Add("404007454272504");
            grid.Add("549043809916080");
            grid.Add("962410809534811");
            grid.Add("445893523733475");
            grid.Add("768705303214174");
            grid.Add("650629270887160");
            List<string> patternGrid = new List<string>();
            patternGrid.Add("99");
            patternGrid.Add("99");

            string foundPatternString = "NO :(";

            for(int i = 0; i< grid.Count(); i++)
            {
                int j = 0;
                var foundIndex = grid[i].IndexOf(patternGrid[j]);
                var initialIndex = foundIndex;
                while (foundIndex == initialIndex && initialIndex != -1 && j < patternGrid.Count())
                {
                    foundIndex = grid[i + j].IndexOf(patternGrid[j]);
                    j++;
                    if(foundIndex == initialIndex && j == patternGrid.Count())
                    {
                        foundPatternString = "YES :)";
                    }
                }
            }
            Console.WriteLine(foundPatternString);
            Console.ReadKey();
        }
    }
}
