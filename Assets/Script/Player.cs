using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
   
    void Update()
    {
        Move();

    }
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float posx = transform.position.x + (horizontal *speed * Time.deltaTime);
        Vector3 temp_pos = new Vector3(Mathf.Clamp(posx, -7.5f, 7.5f), transform.position.y, transform.position.z);
        transform.position = temp_pos;
    }
   
    
}
