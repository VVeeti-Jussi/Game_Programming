using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{

    public class PolyWalkingEnemy
    {
        GetEnemy enemy = new GetEnemy();
        Walking walking = new Walking();

        public PolyWalkingEnemy()
        {
            enemy.EnemyType(walking);
        }

        public class Walking : Enemy
        {
            public override void Type()
            {
                Debug.Log("walking");
            }
        }
    }
}
