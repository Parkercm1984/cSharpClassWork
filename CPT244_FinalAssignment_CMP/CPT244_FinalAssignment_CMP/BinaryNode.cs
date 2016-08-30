using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT244_FinalAssignment_CMP
{
    public class BinaryNode<T>
    {
        public T item { get; set; }
        public BinaryNode<T> left { get; set; }
        public BinaryNode<T> right { get; set; }

        public BinaryNode()
        {
        }

        public BinaryNode(T element)
        {
            item = element;
        }

        public BinaryNode(T element, BinaryNode<T> leftNode, BinaryNode<T> rightNode)
        {
            item = element;
            left = leftNode;
            right = rightNode;
        }

        public bool IsLeaf()
        {
            return (left == null && right == null);
        }

        public override String ToString()
        {
            return item.ToString();
        }
    }
}
