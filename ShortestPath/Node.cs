using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    internal class Node
    {
        public string Name { get; set; }
        public Dictionary<Node,int> DictAdjCosts { get;set; }
        

        public Node(string name)
        {
            Name = name;
            DictAdjCosts = new Dictionary<Node, int>();
        }

        public Node()
        {
            Name = "";
            DictAdjCosts = new Dictionary<Node, int>();
        }

    }
}
