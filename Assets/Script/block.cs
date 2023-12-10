using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class block : MonoBehaviour
{
    public Material[] HP;
    int i;
    
    private void Start()
    {
        int ran = Random.Range(0, HP.Length);
        gameObject.GetComponent<Renderer>().material = HP[ran];
        i = ran;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ball")
        {
            if (i == 0)
            {
                Destroy(gameObject);
                
            }
            else
                {
                    gameObject.GetComponent<Renderer>().material = HP[i - 1];
                    
                    i--;
                }
            }
        }
}
