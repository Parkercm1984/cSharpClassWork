using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT244_Assignment3_CMP
{
    class SudokuCheck
    {
        List<String> invalidResults = new List<String>();

        public SudokuCheck() { 
        }



        public List<String> getInvalidResults() {
            return invalidResults;
        }

        public void rowCk(int[,] SudokuProblem)
        {
            int j = 1;

            for (int i = 0; i < 9; i++)
            {
                int timesNumUsed = 0;
                int k = 0;
                while (k < 9)
                {
                    if (j == SudokuProblem[i, 0])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[i, 1])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[i, 2])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[i, 3])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[i, 4])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[i, 5])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[i, 6])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[i, 7])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[i, 8])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }

                    if (timesNumUsed > 1)
                    {
                        invalidResults.Add("ROW: " + i + ": " + "You used the number (" + j + ")   " + timesNumUsed +
                            " times");
                    }
                    k++;
                    j++;
                    timesNumUsed = 0;
                }
                j = 1;
            }
        }// End rowCk

        public void colCk(int[,] SudokuProblem)
        {
            int j = 1;

            for (int i = 0; i < 9; i++)
            {
                int timesNumUsed = 0;
                int k = 0;
                while (k < 9)
                {
                    if (j == SudokuProblem[0, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[1, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[2, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[3, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[4, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[5, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[6, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[7, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }
                    if (j == SudokuProblem[8, i])
                    {
                        timesNumUsed = timesNumUsed + 1;
                    }

                    if (timesNumUsed > 1)
                    {
                        invalidResults.Add("COL: " + i + ": " + "You used the number (" + j + ")   " + timesNumUsed +
                            " times");
                    }
                    k++;
                    j++;
                    timesNumUsed = 0;
                }
                j = 1;
            }
        
        }// End colCk

        public void blockCk(int[,] SudokuProblem)
        {
            int j = 1;
            int m = 0;
            int blk = 0;
            while (m < 9)
            {
                int i = 0;
                
                while (i < 9)
                {

                    int k = 0;
                    while (k < 9)
                    {
                        int timesNumUsed = 0;
                        if (j == SudokuProblem[m, i])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }
                        if (j == SudokuProblem[m, i + 1])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }
                        if (j == SudokuProblem[m, i + 2])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }
                        if (j == SudokuProblem[m + 1, i])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }
                        if (j == SudokuProblem[ m + 1, i + 1])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }
                        if (j == SudokuProblem[m + 1, i + 2])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }
                        if (j == SudokuProblem[m + 2, i])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }
                        if (j == SudokuProblem[m + 2, i + 1])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }
                        if (j == SudokuProblem[m + 2, i + 2])
                        {
                            timesNumUsed = timesNumUsed + 1;
                        }

                        if (timesNumUsed > 1)
                        {
                            invalidResults.Add("BLK: " + blk + ": " + "You used the number (" + j + ")   " + timesNumUsed +
                                " times");
                        }
                        k++;
                        j++;

                    }
                    j = 1;
                    i = i + 3;
                    blk++;
                }
                m = m + 3;
            }
                    
        
        }//end blockCk 


    }
}// End SudokuCheck Class
