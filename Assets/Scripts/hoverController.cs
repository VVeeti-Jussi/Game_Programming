using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401 {
    public class hoverController : MonoBehaviour
    {
        void Start()
        {
            hovering hovering1 = new hovering();
            hovering1.speed = 10;
        }

    }
}
