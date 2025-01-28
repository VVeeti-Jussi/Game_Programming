using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{
    public class TestScript : MonoBehaviour
    {
        SerializeField private Transform[] targetEndPoints;

        // Adjust the speed for the application.
        public float speed = 1.0f;
        
        // The target (cylinder) position.
        private Transform target;
        void Start()
        {
            target = targetEndPoints[0];
        }

        void Update()
        {
            // Move our position a step closer to the target.
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            // Check if the position of the cube and sphere are approximately equal.
            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                // Swap the position of the cylinder.
                target.position *= -1.0f;
                SwapTargetEndPoints();

            }

        }
        public void SwapTargetEndPoints()
        {

        }
    } 
}