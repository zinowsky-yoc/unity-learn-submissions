using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField]
    private float m_Speed = 50f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move() {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalInput * m_Speed * Time.deltaTime, 0, verticalInput * m_Speed * Time.deltaTime);
        transform.Translate(movement, transform);
    }
}
