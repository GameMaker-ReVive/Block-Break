using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ball ball;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ball.point.ToString();
    }
}
