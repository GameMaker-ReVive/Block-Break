using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class login : MonoBehaviour
{
    public Text namea;
    
    public void Player()
    {

        PlayerPrefs.SetString("name1", namea.text);
        Debug.Log(namea.text);

    }
}
