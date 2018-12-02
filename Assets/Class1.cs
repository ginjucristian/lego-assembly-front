using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BFS
{
    public class Graph
    {
        public Node origin;
        public Graph(GameObject cube)
        {
            origin = new Node(0, cube);
        }
    }

    public class Node
    {
        public int Index { get; set; }
        public GameObject cube_Object;
        public List<Node> neighbors;
        public Node(int index, GameObject cube)
        {
            Index = index;
            cube_Object = cube;
            neighbors = new List<Node>();
        }
        public void AddNeighbor(int index, GameObject cube)
        {
            neighbors.Add(new Node(index, cube));
        }
    }

    public class bfs
    {   //FRONT 1 RIGHT 2 BACK 3 LEFT 4 UP 5 DOWN 6
        enum Directions { Origin, Front, Right, Back, Left, Up, Down };
        Directions d = new Directions();
        public Queue<Node> GraphTraverseBFS(Graph graph)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(graph.origin);
            while (queue.Count > 0)
            {
                Node tempNode = queue.Dequeue();
                //Console.WriteLine("Node number: " + tempNode.Index);
                foreach (var item in tempNode.neighbors)
                {
                    queue.Enqueue(item);
                    Renderer cube_Renderer = item.cube_Object.GetComponent<Renderer>();
                    cube_Renderer.material.color = Color.green;

                }
            }
            return queue;
        }

        public bfs(GameObject[] list_All_Cubes)
        {
            Queue<Node> queue = new Queue<Node>();
            GameObject origin_Cube = GameObject.FindGameObjectWithTag("OriginCube");
            Graph cube_Graph = new Graph(origin_Cube);
            AddNeighbours(cube_Graph.origin, list_All_Cubes);
            queue = GraphTraverseBFS(cube_Graph);
        }

        GameObject CheckForCube(float x, float y, float z, GameObject[] list_All_Cubes)
        {
            foreach (GameObject cube in list_All_Cubes)
            {
                if (x == cube.transform.position.x)
                    if (y == cube.transform.position.y)
                        if (z == cube.transform.position.z)
                        {
                            //this means the cube exists
                            Console.WriteLine("x, y, z " + x + y + z);
                            return cube;
                        }
            }
            GameObject origin_Cube = GameObject.FindGameObjectWithTag("OriginCube");
            return origin_Cube;
        }

        public void AddNeighbours(Node node, GameObject[] list_All_Cubes)
        {
            
            Transform this_Cube = node.cube_Object.transform;
            Debug.Log("Called AddNeighbours with node at: pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z);
            float x, y, z;
            GameObject next_Cube, origin_Cube;
            origin_Cube = GameObject.FindGameObjectWithTag("OriginCube");
            //FRONT 1 z++
            x = this_Cube.position.x;
            y = this_Cube.position.y;
            z = this_Cube.position.z + 1;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
            {
                node.AddNeighbor(0, next_Cube);
                
                Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);

            }

            //RIGHT 2 x++
            x = this_Cube.position.x + 1;
            y = this_Cube.position.y;
            z = this_Cube.position.z;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
            {
                node.AddNeighbor(1, next_Cube);
                
                Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
                
            }

            //BACK  3 z--
            x = this_Cube.position.x;
            y = this_Cube.position.y;
            z = this_Cube.position.z - 1;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
            {
                node.AddNeighbor(2, next_Cube);
                
                Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
                
            }

            //LEFT  4 x--
            x = this_Cube.position.x - 1;
            y = this_Cube.position.y;
            z = this_Cube.position.z;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
            {
                node.AddNeighbor(3, next_Cube);
                //AddNeighbours(node.neighbors[3], list_All_Cubes);
                Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
            }

            //UP    5 y++
            x = this_Cube.position.x;
            y = this_Cube.position.y + 1;
            z = this_Cube.position.z;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
            {
                node.AddNeighbor(4, next_Cube);
                //AddNeighbours(node.neighbors[4], list_All_Cubes);
                Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
            }

            //DOWN  6 y--
            x = this_Cube.position.x;
            y = this_Cube.position.y - 1;
            z = this_Cube.position.z;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
            {
                node.AddNeighbor(5, next_Cube);
                //AddNeighbours(node.neighbors[5], list_All_Cubes);
                Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
            }

            AddNeighbours(node.neighbors[0], list_All_Cubes);
            //AddNeighbours(node.neighbors[1], list_All_Cubes);

        }

    }

}
