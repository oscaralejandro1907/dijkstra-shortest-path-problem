using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    internal class Node
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Node predecessorNode { get; set; }
        public List<Node> ListAdjacentNodes { get; set; }

        public Node(int id)
        {
            Id = id;
            ListAdjacentNodes = new List<Node>();
        }
    }
}
