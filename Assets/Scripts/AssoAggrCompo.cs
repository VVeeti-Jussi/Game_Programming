using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AE3401
{
public class Aac : MonoBehaviour
{
        //Association
        public class Base
        {
            public string Type { get; set; }
        }

        public class Icecream
        {
            public string Type { get; set; }
            public Base AssignedBase { get; set; }
        }

        public class Topping
        { 
            public string Type { get; set; }
            public Icecream AssignedIcecream { get; set; }
        }

        Icecream icecream = new Icecream();
        Topping topping = new Topping();
        public Aac()
        {
            icecream.AssignedBase = new Base { Type = "cone" };
            topping.AssignedIcecream = new Icecream { Type = "chocolate" };
            topping = new Topping { Type = "candy" };
        }

        //--------------------------------------------------------

        // Aggregation
}
}
