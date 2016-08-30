using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT244_Assignment3_CMP
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("C:/Users/Craig/Desktop/Computer Courses/CPT244/Assignments/CPT244_Assignment3_CMP/Program-3/Program-3/sudoku-bad-1.txt");
            int[,] Sudoku = new int[9,9];
            int i = 0;
            List<String> invalidResults;
            SudokuCheck checker = new SudokuCheck();

            while (Sudoku[8,8] == 0)
            {       
                
                while (i < 9)
                {
                    int j = 0;
                    int k = 0;
                    String line = input.ReadLine();
                    String[] split;
                    split = line.Split(',');
                    while (split.Length > k)
                    {
                        Sudoku[i, j] = Int32.Parse(split[k]);
                        k++;
                        j++;
                    }
                    i++;  
                }                
            }

            checker.rowCk(Sudoku);
            checker.colCk(Sudoku);
            checker.blockCk(Sudoku);

            invalidResults = checker.getInvalidResults();

            if (invalidResults.Count == 0) {

                Console.WriteLine("Solution Valid");
            }

            if (invalidResults.Count > 0)
            {
                Console.WriteLine("----The puzzle has the following errors----------\n");
                for (int m = 0;  invalidResults.Count > m; m++)
                {
                    Console.WriteLine(invalidResults[m]);
                }
            }
            Console.Read();
        }
    }
}
