using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{
    public class Enemy
    {
        public virtual void Type()
        {
            Debug.Log("text");
        }
    }

    public class GetEnemy
    {
        public void EnemyType(Enemy enemy)
        {
            enemy.Type();
        }
    }

}

