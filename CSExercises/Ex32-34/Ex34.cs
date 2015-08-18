using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] studentFile = new int[12, 4]{{56,84,68,29},
                                                {94,73,31,89},
                                                {41,63,36,90},
                                                {99,9,18,17},
                                                {62,3,65,75},
                                                {40,96,53,23},
                                                {81,15,27,30},
                                                {21,70,100,22},
                                                {88,50,13,12},
                                                {48,54,52,78},
                                                {64,71,67,25},
                                                {16,93,46,72}
                                               };

            long average;
            long totalMark = 0;
            long overallMark = 0;
            for(int i=0; i<studentFile.Length-1; i++)
            {

                long marks = 0;
               
                for (int j=0; j<4 -1; j++)
                {
                    marks = marks + studentFile[i, j];
                    overallMark = overallMark + studentFile[i, j];
                }
                System.Console.WriteLine("No" + i + " student total marks: " + marks);
                
               
            }
            for (int y = 0; y < 4; y++ )
            {
                for (int x = 0; x < studentFile.Length - 1; x++)
                {
                    totalMark = totalMark + studentFile[x, y];
                }
                average = totalMark / 12;
                System.Console.WriteLine("Average of subject " + average);
            }

            System.Console.WriteLine("The whole class of overall mark: " + overallMark / 48);
            
        }
    }
}
