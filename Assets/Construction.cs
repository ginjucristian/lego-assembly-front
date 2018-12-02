using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using BFS;

namespace Construction
{
    internal class Construction : MonoBehaviour
    {
        GameObject[] list_All_Cubes;
        GameObject origin_Cube;
        bfs search;
        // Use this for initialization
        void Start()
        {
            origin_Cube = GameObject.FindGameObjectWithTag("OriginCube");
            list_All_Cubes = GameObject.FindGameObjectsWithTag("Cube");
            foreach (GameObject cube in list_All_Cubes)
            {
                Debug.Log("cube at :" + "pos X: " + cube.transform.position.x + "pos Y: " + cube.transform.position.y + "pos Z: " + cube.transform.position.z);
            }
            search = new bfs(list_All_Cubes);


        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnMouseOver()
        {

        }

        //bool CheckForCube(GameObject cube_To_Check, GameObject[] list_All_Cubes)
        //{
        //    foreach (GameObject cube in list_All_Cubes)
        //    {
        //        if (cube_To_Check.transform.position.x == cube.transform.position.x)
        //            if (cube_To_Check.transform.position.y == cube.transform.position.y)
        //                if (cube_To_Check.transform.position.z == cube.transform.position.z)
        //                {
        //                    //this means the cube exists
        //                    return true;
        //                }
        //    }
        //    return false;
        //}
    }
}