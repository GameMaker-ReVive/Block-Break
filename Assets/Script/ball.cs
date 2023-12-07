using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float initialForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        LaunchBall();
    }

    void LaunchBall()
    {
        // 랜덤한 방향으로 초기 힘을 가해서 공을 발사
        Vector3 initialDirection = new Vector3(Random.Range(-1f, 1f), 1f, Random.Range(-1f, 1f)).normalized;
        rb.AddForce(initialDirection * initialForce, ForceMode.Impulse);
    }

}
