using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;

namespace AE3401 {

public class Inheritance : MonoBehaviour
{
        public int damage;
        public int health;
        public int death;
     protected virtual void Death()
        {
          
        }
     protected virtual void Health()
        {

        }
}
}
