using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_A : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 300f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
