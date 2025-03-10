using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{
public abstract class Abstract : MonoBehaviour
{
    public string tagName = "Player";
    public string tagName2 = "EditorOnly";

        public abstract void Find();

}
}
