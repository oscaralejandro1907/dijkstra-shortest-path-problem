using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    internal class Data
    {
         public List<Node> ListNodes { get; set; }

        public Data()
        {
            ListNodes = new List<Node>();
            MakeGraph();
        }

        public void MakeGraph()
        {
            Node NewYork = new Node("New York");
            Node Miami = new Node("Miami");
            Node Chicago = new Node("Chicago");
            Node Dallas = new Node("Dallas");
            Node Denver = new Node("Denver");
            Node SanFrancisco = new Node("San Francisco");
            Node LA = new Node("Los Angeles");
            Node SanDiego = new Node("San Diego");

            ListNodes.Add(NewYork);
            ListNodes.Add(Miami);
            ListNodes.Add(Chicago);
            ListNodes.Add(Dallas);
            ListNodes.Add(Denver);               
            ListNodes.Add(SanFrancisco);
            ListNodes.Add(LA);
            ListNodes.Add(SanDiego);

            NewYork.DictAdjCosts.Add(Miami, 90);
            NewYork.DictAdjCosts.Add(Chicago,75);
            NewYork.DictAdjCosts.Add(Dallas, 125);
            NewYork.DictAdjCosts.Add(Denver, 100);

            Miami.DictAdjCosts.Add(Dallas, 50);

            Chicago.DictAdjCosts.Add(SanFrancisco, 25);
            Chicago.DictAdjCosts.Add(Denver, 20);

            Dallas.DictAdjCosts.Add(SanDiego, 90);
            Dallas.DictAdjCosts.Add(LA, 80);

            Denver.DictAdjCosts.Add(SanFrancisco, 75);
            Denver.DictAdjCosts.Add(LA, 100);

            SanFrancisco.DictAdjCosts.Add(LA, 45);

            SanDiego.DictAdjCosts.Add(LA, 45);
        }
    }
}
