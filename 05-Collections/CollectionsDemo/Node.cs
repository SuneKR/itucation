using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }
        public Node(Object Data, Node Next)
        {
            this.Data = Data;
            this.Next = Next;
        }
    }
}
