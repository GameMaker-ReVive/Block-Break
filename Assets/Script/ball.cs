using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rigid;
    Vector3 lastVelocity;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(Vector3.down * 10f, ForceMode.Impulse);
    }

    private void Update()
    {
        lastVelocity = rigid.velocity;
    }

    private void OnCollisionEnter(Collision coll)
    {
        var speed = lastVelocity.magnitude;
        var dir = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);
    
        rigid.velocity = dir * Mathf.Max(speed, 10f);
    }

}
