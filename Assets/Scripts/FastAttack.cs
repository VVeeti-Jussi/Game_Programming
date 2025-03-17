using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{ 

    public class FastAttack : Interface, IAttack
    {
        public static FastAttack instance;
        public void Attack() 
        {
            Debug.Log("fast");
        }

    }
}
