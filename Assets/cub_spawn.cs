using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cub_spawn : MonoBehaviour
{
    
    // Use this for initialization
    IEnumerator Start(){
        int x, y, z;
        y = 5; z = -5;
        for (x = -4; x <= 4; x = x + 2)
        {
            yield return new WaitForSeconds(1);
            cub(x, y, z);
        }
    }
    

    void cub(int x, int y, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);
        cube.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
