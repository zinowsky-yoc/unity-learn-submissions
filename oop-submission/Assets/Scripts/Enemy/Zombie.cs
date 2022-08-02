using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Zombie : Enemy
{
    protected float enemySpeed = 35f;
    protected float destroyAfterSec = 10f;
    protected float enemyFieldOfView = 25f;
    protected bool hasLockedTarget = false;

    private void Awake() {
        Destroy(gameObject, destroyAfterSec);
    }

    protected override void MoveToTarget()
    {
        if (hasLockedTarget) {
            Vector3 targetPos = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
            gameObject.transform.LookAt(targetPos);
            Vector3 movement = (targetPos - gameObject.transform.position).normalized * enemySpeed * Time.deltaTime;
            gameObject.transform.Translate(movement, Space.World);
        }
    }

    private void Update() {
        if (UtilityHelper.IsInMagnitude(gameObject.transform.position, target.transform.position, enemyFieldOfView)) {
            hasLockedTarget = true;
        } else {
            hasLockedTarget = false;
        }
    }
}
