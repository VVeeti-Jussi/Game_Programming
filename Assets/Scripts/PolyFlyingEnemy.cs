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
    }
}
