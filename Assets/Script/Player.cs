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
        float v = Input.GetAxis("Vertical");

        transform.position += new Vector3(h, 0, v) * speed * Time.deltaTime;
        // 오른쪽 방향의 레이
        RaycastCheck(Vector3.right);

        // 왼쪽 방향의 레이
        RaycastCheck(Vector3.left);
    }

    void RaycastCheck(Vector3 direction)
    {
        // 캐릭터의 현재 위치
        Vector3 origin = transform.position;

        RaycastHit hit;
        if (Physics.Raycast(origin, direction, out hit, rayle, layerMask))
        {

            if (hit.collider.CompareTag("side"))
            {
                speed = 0f;
                Debug.Log("Stop Player");
            }
        }
    }
}
