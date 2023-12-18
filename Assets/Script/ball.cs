using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rigid;
    Vector3 lastVelocity;
    bool gamestart = true;
    bool isdead = false;
    public GameObject player;
    public GameManager GM;
    public int point;
    public int image;
    void Start()
    {
        PlayerPrefs.DeleteAll();
        rigid = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        lastVelocity = rigid.velocity;
        if (gamestart == true  && Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.parent = null;
            push();
            gamestart = false;
            isdead = false;
        }
    }

    public void OnCollisionEnter(Collision coll)
    {
        var speed = lastVelocity.magnitude;
        var dir = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);
    
        rigid.velocity = dir * Mathf.Max(speed, 10f);

        if (Mathf.Abs(rigid.velocity.normalized.y) <= 0.2f)
        {
            if (Mathf.Sign(rigid.velocity.normalized.y) >= 0)
            {
                rigid.velocity = new Vector3(rigid.velocity.x, 3f, 0).normalized * speed;

            }
            else
            {
                rigid.velocity = new Vector3(rigid.velocity.x, -3f, 0).normalized * speed;
            }
        }
        if (coll.gameObject.tag == "dead" && isdead == false)
        {
            Debug.Log("2น๘ตส?");
            gameObject.transform.parent = player.transform;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            lastVelocity = Vector3.zero;
            transform.position = player.transform.position + new Vector3(0, 2, 0);
            gamestart = true;
            isdead = true;
            GM.ScoreSet(point, GM.name);
            point = 0;
        }

        if (coll.gameObject.tag == "block")
        {
            point += 100;
            image += 100;
            GM.ground();
        }
    }

    private void push()
    {
        rigid.AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }
}
