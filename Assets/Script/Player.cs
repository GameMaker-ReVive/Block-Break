using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float rayle = 0.5f;
    public LayerMask layerMask;
    void Update()
    {
        Move();

    }
    void Move()
    {
        float h = Input.GetAxis("Horizontal");

        transform.position += new Vector3(h, 0, 0) * speed * Time.deltaTime;
    }

}
