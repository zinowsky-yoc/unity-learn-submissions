using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Player : MovementController
{
    private int health = 5;
    protected float Timer;
    private float delayInSec = 5f;

    private void Update() {
        Timer += Time.deltaTime;
        if (Timer >= delayInSec) {
            Timer = 0f;
            health++;
            Debug.Log("Health: " + health);
        }
        Move();
        if (health <= 0) {
            Debug.Log("GameOver");
        }
    }

    private void OnTriggerEnter(Collider other) {
        health -= 3;
        Debug.Log("Health: " + health);
        if (other.CompareTag("Enemy")) {
            Destroy(other.gameObject);
        }
    }
}
