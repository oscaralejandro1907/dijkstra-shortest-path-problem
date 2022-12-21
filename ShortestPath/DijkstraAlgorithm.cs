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

        public Dictionary<Node, int> DictionaryDistances { get; set; }
        public Dictionary<Node,Node> DictionaryShortestPath { get; set; } //Route
        

        public DijkstraAlgorithm(Data data,Node source) 
        {
            Data = data;
            ListNodes = data.ListNodes;

            DictionaryDistances = new Dictionary<Node, int>();          // "best distance/cost" from the source node to every other node.
            DictionaryShortestPath = new Dictionary<Node,Node>();   //indicates what node was used to reach n, to get the best distance

            //Initialize Costs
            source = ListNodes[0];         
           
            foreach (Node n in ListNodes)
            {
                if(n.Equals(source))
                {
                    DictionaryDistances.Add(n, 0);
                }
                else
                {
                    DictionaryDistances.Add(n,int.MaxValue);
                }
            }        

        }

        public void SolveDijkstra()
        {
            List<Node> listUnvisitedNodes = new(ListNodes);
           
            while(listUnvisitedNodes.Count > 0)
            {
                Node cheapestCity = GetCheapestNode(listUnvisitedNodes);
                ExamineConnections(cheapestCity);
                listUnvisitedNodes.Remove(cheapestCity);

            }          

        }

        public Node GetCheapestNode(List<Node> listUnvisitedNodes)
        {
            //Extract lowest value in distance table
            Node cheapestCity = new Node();
            int minD = int.MaxValue;
            foreach(Node n in listUnvisitedNodes)
            {
                if (DictionaryDistances[n] < minD)
                {
                    minD = DictionaryDistances[n];
                    cheapestCity = n;

                }
            }

            return cheapestCity;
        }

        public void ExamineConnections(Node cheapestCity)
        {
            //Examine neighbors and check if cost is less thant the best known in DictionaryDistances
            foreach (var neighbor in cheapestCity.DictAdjCosts)
            {
                if (DictionaryDistances[cheapestCity] + neighbor.Value < DictionaryDistances[neighbor.Key])
                {
                    DictionaryDistances[neighbor.Key] = neighbor.Value + DictionaryDistances[cheapestCity];
                    DictionaryShortestPath[neighbor.Key] = cheapestCity;
                }
            }
        }
    }
}
