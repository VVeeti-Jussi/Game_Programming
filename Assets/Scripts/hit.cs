using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class hit : MonoBehaviour
{
    
    void Start()
    {
     void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "enemy")
            {
                transform.position = new Vector3(2, 2, 0);
            }
        }
    }
}
