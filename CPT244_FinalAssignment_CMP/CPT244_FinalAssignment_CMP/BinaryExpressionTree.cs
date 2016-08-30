using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT244_FinalAssignment_CMP
{
    class BinaryExpressionTree
    {
        public int Count { get; set; }
        public BinaryNode<char> rootNode { get; private set; }
        private string origExpression;

        public BinaryExpressionTree(String expression)
        {
            origExpression = expression;
            rootNode = Parse(expression);
        }

        public BinaryNode<char> Parse(string expression)
        {

            Stack<BinaryNode<char>> nodeStack = new Stack<BinaryNode<char>>();
            BinaryNode<char> curNode = null;

            foreach(char currentToken in expression ){

                switch (currentToken) {

                    case '(':
                        {
                            if (curNode != null)
                            {
                                nodeStack.Push(curNode);                            
                            }
                            curNode = new BinaryNode<char>();
                        break;
                        }
                    case ')':
                        {
                            if(nodeStack.Count != 0)
                            {
                                BinaryNode<char> childNode = curNode;
                                curNode = nodeStack.Pop();

                                if (curNode.left == null)
                                {
                                    curNode.left = childNode;
                                }

                                else if (curNode.right == null)
                                {
                                    curNode.right = childNode;
                                }
                                else 
                                {
                                    Console.WriteLine("Error: current node is full");                                
                                }
                            }
                        break;
                        }

                    case '+':
                    case '-':
                    case '/':
                    case '*':
                    case '^':
                        {
                            curNode.item = currentToken;
                            break;
                        }

                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        {
                            BinaryNode<char> newLeaf = new BinaryNode<char>(currentToken);

                            if (curNode.left == null)
                            {
                                curNode.left = newLeaf;
                            }

                            else if (curNode.right == null)
                            {
                                curNode.right = newLeaf;
                            }
                            else
                            {
                                Console.WriteLine("Error: current node is full");
                            }

                            break;
                        }                
                }//End switch
            }//end for loop
            return curNode;
        }//End Parse

        public double Evaluate()
        {
           
            if(rootNode == null)
            {
                Console.WriteLine("Tree is empty.");
                return 0;
            }
            return Evaluate(rootNode);
        }

        private double Evaluate(BinaryNode<char> node)
        {
            double value = 0;
            if (node.IsLeaf())
            {
                
                // cheap way to convert a single digit number to an integer
                value = node.item - '0';
            }
            else
            {
                double left;
                double right;
                char op = node.item;

                left = Evaluate(node.left);
                right = Evaluate(node.right);

                switch(op)
                {
                    case '+':
                        {
                            value = left + right;
                            break;
                        }
                    case '-':
                        {
                            value = left - right;
                            break;
                        }
                    case '*':
                        {
                            value = left * right;
                            break;
                        }
                    case '/':
                        {
                            value = left / right;
                            break;
                        }
                    case '^':
                        {
                            value = Math.Pow(left, right);
                            break;
                        }

                
                
                }


            }

            return value;
        }

        public void DisplayInOrder()
        {
            if (rootNode != null)
            {
                DisplayInOrder(rootNode);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Tree is empty.");
            }
        }

        private void DisplayInOrder(BinaryNode<char> node)
        {
            if (node.IsLeaf())
                Console.Write(node.item);
            else
            {
                Console.Write('(');
                DisplayInOrder(node.left);
                Console.Write(node.item);
                DisplayInOrder(node.right);
                Console.Write(')');
            }
        }

        public void DisplayPreOrder()
        {
             if (rootNode != null)
            {
                DisplayPreOrder(rootNode);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Tree is empty.");
            }

        }

        private void DisplayPreOrder(BinaryNode<char> node)
        {
            if (node != null)
            {
                Console.Write(node.item);
                DisplayPreOrder(node.left);
                DisplayPreOrder(node.right);
            }

        }

        public void DisplayPostOrder()
        {
            if (rootNode != null)
            {
                DisplayPostOrder(rootNode);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Tree is empty.");
            }
        }

        private void DisplayPostOrder(BinaryNode<char> node)
        {
            if (node != null)
            {
                
                DisplayPostOrder(node.left);
                DisplayPostOrder(node.right);
                Console.Write(node.item);
            }
        
        }



    }
}

           