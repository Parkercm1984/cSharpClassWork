using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT244_FinalAssignment_CMP
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = 'n';
            string expression;
            

            Console.WriteLine("-----Welcome to Binary Expression evaluator-----");

            while(exit != 'y')
            {
                Console.WriteLine("Please input a fully parenthesized expression below");
                Console.WriteLine("Expression Example: ((3*(8-2))-(1+9))");
                Console.WriteLine("Acceptable operators: + - * / ^ \n");
            


                expression = Console.ReadLine(); 
                BinaryExpressionTree bet = new BinaryExpressionTree(expression);
                Console.Write("Infix: ");
                bet.DisplayInOrder();
                Console.Write("Postfix: ");
                bet.DisplayPostOrder();
                Console.Write("Prefix: ");
                bet.DisplayPreOrder();
                Console.WriteLine("{0} = {1}", expression, bet.Evaluate());

                Console.Write("Exit? (y/n) ");
                exit = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            }
        }
    }
}