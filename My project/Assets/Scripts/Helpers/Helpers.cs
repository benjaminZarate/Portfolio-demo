using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helpers
{
    public static Transform GetPlayer() 
    {
        return GameObject.FindGameObjectWithTag("Player").transform;
    }
}
