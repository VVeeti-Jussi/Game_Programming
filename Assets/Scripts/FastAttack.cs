using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{ 
public interface IAttack
    {
        void Attack();
    }

    public class FastAttack : IAttack
    {
        public static FastAttack instance;
        public void Attack() 
        {
            Debug.Log("fast");
        }

    }
}
