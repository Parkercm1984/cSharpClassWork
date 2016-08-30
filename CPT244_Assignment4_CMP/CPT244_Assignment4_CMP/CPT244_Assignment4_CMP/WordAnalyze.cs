using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT244_Assignment4_CMP
{
    class WordAnalyze
    {
       private Dictionary<String, int> book = new Dictionary<string, int>();
        public WordAnalyze() { }

        public void stuff()
        {
            
            book.Add("Test", 33);
            int test = 0;
            if (book.TryGetValue("Test", out test))
            {
                test = test + 1;

            }
            book["Test"] = test;

            foreach (KeyValuePair<string, int> entry in book)
            {
                Console.WriteLine(entry.Key + " used " + entry.Value);
            }
        }//end stuff


        public void addLine(String lineToAdd) { 
            String[] wordsToAdd;
            int i = 0;
            wordsToAdd = lineToAdd.Split(null);

            while (wordsToAdd.Count() > i) {
                int isUsed;
                if (book.TryGetValue(wordsToAdd[i], out isUsed))
                {
                    book[wordsToAdd[i]] = book[wordsToAdd[i]] + 1;
                
                }
                else
                {
                    book.Add(wordsToAdd[i], 1);
                }
                i++;
            }        
        }//End addLine


        public void returnCount() {

            int totalWords = 0;
            String mostUsedWord = null;
            


            foreach (KeyValuePair<string, int> entry in book)
            {
                totalWords = totalWords + entry.Value;

                if (mostUsedWord == null) 
                {
                    mostUsedWord = entry.Key;
                }

                if(entry.Value > book[mostUsedWord])
                {
                    mostUsedWord = entry.Key;
                }

            }

            Console.WriteLine("Book Totals");
            Console.WriteLine("Total Words: " + totalWords);
            Console.WriteLine("Different Words: " + book.Count);
            Console.WriteLine("Most Used Word: " + mostUsedWord + " was used " + book[mostUsedWord] + " times");
            Console.WriteLine("Times the Word (count) Appeared: " + book["count"]);
            Console.WriteLine("Times the Word (may) Appeared: " + book["may"]);
            Console.WriteLine("Times the Word (color) Appeared: " + book["color"]);
        }//End returnCount

        public void userInput() { 
            bool exit = false;
            while (exit != true) 
            {
                Console.WriteLine("Welcome to Wrod Analyzer");
                Console.WriteLine("Input (1) to see how many times a word appears in the text");
                Console.WriteLine("Input (2) to see how many words appear a specific number of times");
                Console.WriteLine("Input (3) to see how many words are a specific length ");
                Console.WriteLine("Type (Exit) to exit program");
                String userChoice = Console.ReadLine();


                if (userChoice == "1")
                {

                    Console.WriteLine("Please type the word you wish to search for");
                    String wordToSearch = Console.ReadLine();
                    int isUsed;
                    if(book.TryGetValue(wordToSearch, out isUsed))
                    {
                        Console.WriteLine("The word: " + wordToSearch + " was used " + book[wordToSearch] + " times");
                        Console.WriteLine("Hit Enter two times to return to menu");
                    }
                    else
                    {
                        Console.WriteLine("The word " + wordToSearch + " was not found");
                        Console.WriteLine("Hit Enter two times to return to menu");
                    }

                }

                if(userChoice == "2")
                {
                    Console.WriteLine("Input the number of times the word should appear in the text");
                    int numToSearch = Int32.Parse(Console.ReadLine());
                    bool numberFound = false;

                    foreach (KeyValuePair<string, int> entry in book)
                    { 
                        if(entry.Value == numToSearch)
                        {
                            Console.WriteLine("The word " + entry.Key + " was used " + entry.Value + " times");
                            numberFound = true;
                        }
                    }
                    if (numberFound == false)
                    {
                        Console.WriteLine("No words were used: " + numToSearch + " times");
                    }
                    Console.WriteLine("Hit Enter two times to return to menu");

                }

                if (userChoice == "3")
                {
                    Console.WriteLine("Input the lenth to search for");
                    int length = Int32.Parse(Console.ReadLine());
                    bool found = false;

                    foreach (KeyValuePair<string, int> entry in book)
                    {
                        if (length == entry.Key.Length)
                        {
                            Console.WriteLine("The word " + entry.Key + " is " + entry.Key.Length + " characters long and in the text " + entry.Value + " times" );
                            found = true;
                        }
                    }
                    if(found == false)
                    {
                        Console.WriteLine("There were no words with a length of " + length);
                    }
                    Console.WriteLine("Hit Enter two times to return to menu");

                }


                if (userChoice == "exit" || Console.ReadLine() == "Exit")
                {
                    exit = true;
                }
            }
        
        
        }//End userInput

    }
}
