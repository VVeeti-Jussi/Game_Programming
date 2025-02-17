using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

namespace AE3401
{
    public class UpAndDown : MonoBehaviour
    {
        [SerializeField] private float amp;
        [SerializeField] private float freq;
        Vector3 initPos;

        private void Start()
        {
            initPos = transform.position;

            Debug.Log(Write(amp, freq));
        }
        private void Update()
        {
            transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * freq) * amp + initPos.y, 0);
        }
        
        private float Write(float a, float f)
        {
            return a + f;
        }

    }
}

