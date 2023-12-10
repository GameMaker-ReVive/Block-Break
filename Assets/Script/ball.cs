using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rb;
    public int scr;
    public GameManager gamemanager;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
     
    }
    private void FixedUpdate()
    {
        
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            PushStart();
            gameObject.transform.SetParent(null);
        }
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
    void OnCollisionEnter(Collision other){
        if(other.gameObject.name == "down"){
            Death();
            gamemanager.Check();
        }
       
       
    }
  
    void Death(){
        this.gameObject.SetActive(false);
        Debug.Log("사망");
    }
}
