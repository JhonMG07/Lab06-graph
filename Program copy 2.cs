// namespace Lab06_graph;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create an instance of the Graph class with directed and weighted set to false
//         Graph<int> graph = new Graph<int>(true, true);

//         // Add nodes 1, 2, 3, 4, 5, 6, 7, 8 to the graph
//         Node<int> node1 = graph.AddNode(1);
//         Node<int> node2 = graph.AddNode(2);
//         Node<int> node3 = graph.AddNode(3);
//         Node<int> node4 = graph.AddNode(4);
//         Node<int> node5 = graph.AddNode(5);
//         Node<int> node6 = graph.AddNode(6);
//         Node<int> node7 = graph.AddNode(7);
//         Node<int> node8 = graph.AddNode(8);

//         // Add edges between the nodes to create the desired graph structure
//         graph.AddEdge(node1, node2);
//         graph.AddEdge(node1, node3);
//         graph.AddEdge(node2, node4);
//         graph.AddEdge(node2, node5);
//         graph.AddEdge(node3, node6);
//         graph.AddEdge(node3, node7);
//         graph.AddEdge(node4, node8);
//         graph.AddEdge(node5, node8);
//         graph.AddEdge(node6, node8);
//         graph.AddEdge(node7, node8);

//         List<Node<int>> dfsNodes = graph.DFS();
//         // Print the nodes and edges of the graph
//         dfsNodes.ForEach(n => Console.WriteLine(n));


//         // Wait for user input before closing the console window
//         Console.ReadLine();
//     }
// }