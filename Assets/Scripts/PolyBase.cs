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

    public class Flying : Enemy
    {
        public override void Type()
        {
            Debug.Log("flying");
        }
    }

    public class Walking : Enemy
    {
        public override void Type()
        {
            Debug.Log("walking");
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

