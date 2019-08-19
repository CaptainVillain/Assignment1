using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() => print("Hello world");

    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            print("Respect");
        }
    }

    public GameObject SpawnCube;

    public void MakeCube()
    {
        Instantiate(SpawnCube, new Vector3(5, 5, 5), Quaternion.identity);
    }
}
