using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        Invoke("Spawn", 3);
    }

    void Spawn()
    { 
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}
