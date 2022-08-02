using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class UtilityHelper
{
    // POLYMORPHISM 
    public static Vector3 CalculateDistance(Vector3 origin, Vector3 remote) {
        return remote - origin;
    }

    public static Vector3 CalculateDistance(Vector3 origin, Vector3 remote, float distance) {
        Vector3 diff = remote - origin;
        float mag = diff.magnitude;
        if (mag < distance) {
            return origin;
        }
        diff.Normalize();
        return (distance * diff) + origin;
    }
}
