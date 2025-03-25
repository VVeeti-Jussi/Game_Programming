using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{

    public class PolyFlyingEnemy
    {
        GetEnemy enemy = new GetEnemy();
        Flying flying = new Flying();

        public PolyFlyingEnemy()
        {
            enemy.EnemyType(flying);
        }

        public class Flying : Enemy
        {
            public override void Type()
            {
                Debug.Log("flying");
            }
        }
    }
}
