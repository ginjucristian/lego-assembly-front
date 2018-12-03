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
            origin = new Node(cube);
        }
    }

    public class Node
    {
        public GameObject cube_Object;
        public List<Node> neighbors;
        public Node(GameObject cube)
        {
            cube_Object = cube;
            neighbors = new List<Node>();
        }
        public void AddNeighbor(GameObject cube)
        {
            neighbors.Add(new Node(cube));
        }
    }

    public class bfs
    {
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

        public bfs(List<GameObject> list_All_Cubes)
        {
            Queue<Node> queue = new Queue<Node>();
            GameObject origin_Cube = GameObject.FindGameObjectWithTag("OriginCube");
            Graph cube_Graph = new Graph(origin_Cube);
            AddNeighbours(cube_Graph.origin, list_All_Cubes);
            queue = GraphTraverseBFS(cube_Graph);
            foreach(GameObject cube in list_All_Cubes)
            {
                Renderer rend_cube = cube.GetComponent<Renderer>();
                rend_cube.material.color = Color.red;
            }
        }

        GameObject CheckForCube(float x, float y, float z, List<GameObject> list_All_Cubes)
        {
            foreach (GameObject cube in list_All_Cubes)
            {
                if (x == cube.transform.position.x)
                    if (y == cube.transform.position.y)
                        if (z == cube.transform.position.z)
                        {
                            //this means the cube exists
                            return cube;
                        }
            }
            GameObject origin_Cube = GameObject.FindGameObjectWithTag("OriginCube");
            return origin_Cube;
        }

        public void AddNeighbours(Node node, List<GameObject> list_All_Cubes)
        {
            
            Transform this_Cube = node.cube_Object.transform;
            Debug.Log("Called AddNeighbours with node at: pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z);
            float x, y, z;
            x = this_Cube.position.x;
            y = this_Cube.position.y;
            z = this_Cube.position.z;
            GameObject next_Cube, origin_Cube;
            origin_Cube = GameObject.FindGameObjectWithTag("OriginCube");
            //FRONT 1 z++
            z++;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (list_All_Cubes.Contains(next_Cube))
            {
                if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
                {
                    node.AddNeighbor(next_Cube);
                    list_All_Cubes.Remove(node.cube_Object);
                    Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
                    Node temp_node = node.neighbors.Find(nude => nude.cube_Object.Equals(next_Cube));
                    AddNeighbours(temp_node, list_All_Cubes);
                }
            }
            z--;

            //RIGHT 2 x++
            x++;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (list_All_Cubes.Contains(next_Cube))
            {
                if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
                {
                    node.AddNeighbor(next_Cube);
                    list_All_Cubes.Remove(next_Cube);
                    Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
                    Node temp_node = node.neighbors.Find(nude => nude.cube_Object.Equals(next_Cube));
                    AddNeighbours(temp_node, list_All_Cubes);
                }
            }
            x--;

            //BACK  3 z--
            z--;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (list_All_Cubes.Contains(next_Cube))
            {
                if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
                {
                    node.AddNeighbor(next_Cube);
                    list_All_Cubes.Remove(next_Cube);
                    Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
                    Node temp_node = node.neighbors.Find(nude => nude.cube_Object.Equals(next_Cube));
                    AddNeighbours(temp_node, list_All_Cubes);
                }
            }
            z++;

            //LEFT  4 x--
            x--;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (list_All_Cubes.Contains(next_Cube))
            {
                if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
                {
                    node.AddNeighbor(next_Cube);
                    list_All_Cubes.Remove(next_Cube);
                    Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
                    Node temp_node = node.neighbors.Find(nude => nude.cube_Object.Equals(next_Cube));
                    AddNeighbours(temp_node, list_All_Cubes);
                }
            }
            x++;

            //UP    5 y++
            y++;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (list_All_Cubes.Contains(next_Cube))
            {
                if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
                {
                    node.AddNeighbor(next_Cube);
                    list_All_Cubes.Remove(next_Cube);
                    Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
                    Node temp_node = node.neighbors.Find(nude => nude.cube_Object.Equals(next_Cube));
                    AddNeighbours(temp_node, list_All_Cubes);
                }
            }
            y--;

            //DOWN  6 y--
            y--;
            next_Cube = CheckForCube(x, y, z, list_All_Cubes);
            if (list_All_Cubes.Contains(next_Cube))
            {
                if (!GameObject.ReferenceEquals(origin_Cube, next_Cube))
                {
                    node.AddNeighbor( next_Cube);
                    list_All_Cubes.Remove(next_Cube);
                    Debug.Log("cube at : " + "pos X: " + this_Cube.position.x + " pos Y: " + this_Cube.position.y + " pos Z: " + this_Cube.position.z + " has neighbor at : pos X: " + next_Cube.transform.position.x + " pos Y: " + next_Cube.transform.position.y + " pos Z: " + next_Cube.transform.position.z);
                    Node temp_node = node.neighbors.Find(nude => nude.cube_Object.Equals(next_Cube));
                    AddNeighbours(temp_node, list_All_Cubes);
                }
            }
            y++;
        }

    }

}
