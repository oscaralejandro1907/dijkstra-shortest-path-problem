namespace ShortestPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            DijkstraAlgorithm algorithm = new(data, data.ListNodes[0]);
            algorithm.SolveDijkstra();
            algorithm.PrintSolution();
        }
    }
}