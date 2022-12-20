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
            Node a = new Node("0");
            Node b = new Node("1");
            Node c = new Node("2");
            Node d = new Node("3");
            Node e = new Node("4");
            Node f = new Node("5");
            Node g = new Node("6");

            ListNodes.Add(a);
            ListNodes.Add(b);
            ListNodes.Add(c);
            ListNodes.Add(d);
            ListNodes.Add(e);               
            ListNodes.Add(f);
            ListNodes.Add(g);

            a.DictDistances.Add("1", 2);
            a.DictDistances.Add("2", 6);

            b.DictDistances.Add("0", 2);
            b.DictDistances.Add("3", 5);

            c.DictDistances.Add("0", 6);
            c.DictDistances.Add("3", 8);

            d.DictDistances.Add("1", 5);
            d.DictDistances.Add("2", 8);
            d.DictDistances.Add("4", 10);
            d.DictDistances.Add("5", 15);

            e.DictDistances.Add("3", 10);
            e.DictDistances.Add("5", 6);
            e.DictDistances.Add("6", 2);

            f.DictDistances.Add("3", 15);
            f.DictDistances.Add("4", 6);
            f.DictDistances.Add("6", 6);

            g.DictDistances.Add("4", 2);
            g.DictDistances.Add("5", 6);
        }
    }
}
