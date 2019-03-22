using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWebCS
{
    public class Link
    {
        Node a;
        public Node A
        {
            get
            {
                return a;
            }
        }
        Node b;
        public Node B
        {
            get
            {
                return b;
            }
        }
        public Link(Node _a, Node _b)
        {
            a = _a;
            b = _b;
        }
    }
}