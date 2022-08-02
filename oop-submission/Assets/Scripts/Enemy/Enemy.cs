using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Enemy : MonoBehaviour
{
    protected GameObject target;
    
    private void Start() {
        // ABSTRACTION
        target = GameObject.FindWithTag("Player");
    }

    private void FixedUpdate() {
        MoveToTarget();
    }

    // ABSTRACTION
    protected abstract void MoveToTarget();

}
