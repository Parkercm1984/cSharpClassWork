using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT244_Assignment4_CMP
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader input = new StreamReader("C:/Users/Craig/Desktop/Computer Courses/CPT244/Assignments/CPT244_Assignment4_CMP/comc/comc.txt");
            WordAnalyze wAnalyze = new WordAnalyze();

            while (!input.EndOfStream) {
                wAnalyze.addLine(input.ReadLine());
            
            }
            wAnalyze.returnCount();
            wAnalyze.userInput();
        }
    }
}
