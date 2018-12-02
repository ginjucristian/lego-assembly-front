using UnityEngine;
using BFS;

public class ValidateCube : MonoBehaviour {
    Material cube_Material;
    Transform cube_Transform;
    GameObject[] list_All_Cubes;
    GameObject origin_Cube;
    Transform origin_Cube_Transform;

    //FRONT 0 RIGHT 1 BACK 2 LEFT 3 UP 4 DOWN 5 

    
    // Use this for initialization
    void Start () {
        //Fetch the Material from the Renderer of the GameObject
        cube_Material = GetComponent<Renderer>().material;
        cube_Transform = GetComponent<Transform>();
        list_All_Cubes = GameObject.FindGameObjectsWithTag("Cube");
        origin_Cube = GameObject.FindGameObjectWithTag("OriginCube");
        origin_Cube_Transform = origin_Cube.GetComponent<Transform>();
    }

    bool CheckForCube(float x, float y, float z, GameObject[] list_All_Cubes)
    {
        foreach (GameObject cube in list_All_Cubes)
        {
            if (x == cube.transform.position.x)
                if (y == cube.transform.position.y)
                    if (z == cube.transform.position.z)
                    {
                        //this means the cube exists
                        return true;
                    }
        }
        return false;
    }

    // Update is called once per frame
    void Update () {
		
	}

    //Test if color change works
    void OnMouseOver()
    {
    }
}
