using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class UtilityHelper
{
    // POLYMORPHISM 
    public static Vector3 CalculateMoveTo(Vector3 origin, Vector3 remote) {
        Vector3 moveTo = (remote - origin);
        return moveTo;
    }

    public static Vector3 CalculateMoveTo(Vector3 origin, Vector3 remote, float distance) {
        Vector3 diff = remote - origin;
        float mag = diff.magnitude;
        if (mag < distance) {
            return origin;
        }
        diff.Normalize();
        return (distance * diff) + origin;
    }

    public static bool IsInMagnitude(Vector3 origin, Vector3 remote, float magnitudeThreshold) {
        float mag = (remote - origin).magnitude;
        if (mag < magnitudeThreshold) {
            return true;
        } else {
            return false;
        }
    }
}
