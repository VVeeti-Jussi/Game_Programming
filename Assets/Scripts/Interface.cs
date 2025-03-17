using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{
    public interface IAttack
    {
        void Attack();
    }
    public class Interface : MonoBehaviour
{
    void Start()
    {
            FastAttack.instance.Attack();
    }
}
}
