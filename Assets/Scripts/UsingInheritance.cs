using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401 {
public class UsingInheritance : Inheritance
{

        protected override void Death()
        {
            damage = 15;
            health = 10;
            death = health - damage;

            if (death < 0)
            {
                Debug.Log("You died");
            }
        }
}
}
