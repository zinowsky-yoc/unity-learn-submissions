using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ENCAPSULATION
    public GameObject Target {
        get { return m_Target; }
        set { m_Target = value; }
    }

    private GameObject m_Target;

    public float Speed {
        get { return m_Speed; }
        set { m_Speed = value; }
    }
    private float m_Speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        AssignPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        HuntTarget();
    }

    protected void AssignPlayer() {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    public virtual void HuntTarget() {
        Vector3 moveTo = UtilityHelper.CalculateDistance(transform.position, Target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, moveTo, Speed * Time.deltaTime);
    }
}
