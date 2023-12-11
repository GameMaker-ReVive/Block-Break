using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ball ball;
    public Text score;
    public GameObject[] back;

    int ran;
    // Start is called before the first frame update
    void Start()
    {
        ran = Random.Range(0, back.Length);
        back_ground();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ball.point.ToString();
    }

    void back_ground()
    {
        back[ran].SetActive(true);
    }

    public void ground()
    {
        if (ball.point % 500 == 0 && ball.point > 1)
        {
            back[ran].SetActive(false);
            ran = Random.Range(0, back.Length);
            back_ground();
            ball.image = 0;
        }
    }
}
