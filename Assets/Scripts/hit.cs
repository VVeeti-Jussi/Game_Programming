using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace AE3401
{ 

public class hit : MonoBehaviour
{
    [SerializeField] private string tagName = "Player";
    [SerializeField] private string tagName2 = "EditorOnly";
    List<string> list = new List<string>();
    
    private void Start()
    {
     void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "enemy")
            {
                transform.position = new Vector3(2, 2, 0);

            }
        }
        if (GameObject.FindGameObjectWithTag(tagName))
        {
            list.Add("player");
        }

        if (GameObject.FindGameObjectWithTag(tagName2))
        {
            list.Add("quad");
            foreach (string s in list)
                {
                    Debug.Log(s);
                    transform.gameObject.tag = "enemy";
                }
        }

    }
}
}
