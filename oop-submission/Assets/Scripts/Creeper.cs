using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Creeper : Enemy
{
    // Start is called before the first frame update
    /**
    void Start()
    {
        Debug.Log("Hunt!");
        AssignPlayer();
    }
    */

    // Update is called once per frame
    void Update()
    {
        HuntTarget();
    }

    public override void HuntTarget()
    {
        Vector3 moveTo = UtilityHelper.CalculateDistance(transform.position, Target.transform.position, 5f);
        transform.position = Vector3.MoveTowards(transform.position, moveTo, Speed * Time.deltaTime);
    }
}
