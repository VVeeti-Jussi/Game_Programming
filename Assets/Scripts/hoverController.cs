using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

namespace AE3401 {
    public class HoverController : MonoBehaviour
    {
        private float spd;
        private float disx;
        private float disy;
        void Start()
        {
            Hovering hovering1 = new Hovering();
            spd = hovering1.speed;
            disx = hovering1.distancex;
            disy = hovering1.distancey;

        }
        private void Update()
        {
            transform.position = new Vector3(Mathf.Sin(Time.time * spd) + disx, Mathf.Sin(Time.time * spd) + disy, 0);
        }

    }
}
