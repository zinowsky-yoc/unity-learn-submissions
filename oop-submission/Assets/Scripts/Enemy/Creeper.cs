using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Creeper : Enemy
{
    protected float enemySpeed = 20.0f;
    protected float destroyAfterSec = 2.5f;

    private void Awake() {
        Destroy(gameObject, destroyAfterSec);
    }

    protected override void MoveToTarget()
    {
        Vector3 targetPos = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);

        gameObject.transform.LookAt(targetPos);

        Vector3 movement = (targetPos - gameObject.transform.position).normalized * enemySpeed * Time.deltaTime;
        gameObject.transform.Translate(movement, Space.World);
    }

}
