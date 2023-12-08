using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PushStart();
    }
    private void FixedUpdate()
    {
        
    }

/*    void LaunchBall()
    {
        // 랜덤한 방향으로 초기 힘을 가해서 공을 발사
        Vector3 initialDirection = new Vector3(Random.Range(-1f, 1f), 1f, Random.Range(-1f, 1f)).normalized;
        rb.AddForce(initialDirection * 10f, ForceMode.Impulse);
    }*/
    
    void PushStart()
    {
        rb.AddForce(Vector3.down * 15f, ForceMode.Impulse);
    }

}
