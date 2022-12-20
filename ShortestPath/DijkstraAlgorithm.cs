using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    internal class DijkstraAlgorithm
    {
        public Data Data { get; set; } 
        public List<Node> ListNodes { get; set; }
        public List<Node> ListShortestPath { get; set; }

        public DijkstraAlgorithm(Data data) 
        {
            Data = data;
            ListNodes = data.ListNodes; 
            ListShortestPath = new List<Node>();
        }


    }
}
