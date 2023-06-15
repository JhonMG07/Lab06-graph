namespace Lab06_graph;

class Program2
{
    static void Main(string[] args)
    {
        // Create an instance of the Graph class with directed and weighted set to false
        Graph<int> graph = new Graph<int>(true, true);
        // Add nodes 1, 2, 3, 4, 5, 6, 7, 8 to the graph
        Node<int> n1 = graph.AddNode(1);
        Node<int> n2 = graph.AddNode(2);
        Node<int> n3 = graph.AddNode(3);
        Node<int> n4 = graph.AddNode(4);
        Node<int> n5 = graph.AddNode(5);
        Node<int> n6 = graph.AddNode(6);
        Node<int> n7 = graph.AddNode(7);
        Node<int> n8 = graph.AddNode(8);


        // Add edges between the nodes to create the desired graph structure
        graph.AddEdge(n1, n2, 9);
        graph.AddEdge(n1, n3, 5);
        graph.AddEdge(n2, n1, 3);
        graph.AddEdge(n2, n4, 18);
        graph.AddEdge(n3, n4, 12);
        graph.AddEdge(n4, n2, 2);
        graph.AddEdge(n4, n8, 8);
        graph.AddEdge(n5, n4, 9);
        graph.AddEdge(n5, n6, 2);
        graph.AddEdge(n5, n7, 5);
        graph.AddEdge(n5, n8, 3);
        graph.AddEdge(n6, n7, 1);
        graph.AddEdge(n7, n5, 4);
        graph.AddEdge(n7, n8, 6);
        graph.AddEdge(n8, n5, 3);

        // Print the nodes and edges of the graph
        Console.WriteLine("Nodes:");
        foreach (Node<int> node in graph.Nodes)
        {
            Console.WriteLine(node);
        }

        Console.WriteLine("\nEdges:");
        List<Edge<int>> edges = graph.GetEdges();
        foreach (Edge<int> edge in edges)
        {
            Console.WriteLine(edge);
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}