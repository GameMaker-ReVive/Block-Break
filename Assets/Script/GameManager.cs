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
    public string name;
    public Text nick;
    public float[] bestScore = new float[3];
    public string[] bestName = new string[3];
    public Text[] rank;

    int ran;
    // Start is called before the first frame update
    void Start()
    {
        name = PlayerPrefs.GetString("name");
        nick.text = "플레이어 : " + name;
        ran = Random.Range(0, back.Length);
        back_ground();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ball.point.ToString();
        rank[0].text = bestScore[0].ToString();
        rank[1].text = bestScore[1].ToString();
        rank[2].text = bestScore[2].ToString();
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

    public void ScoreSet(float currentScore, string currentName)
    {
        PlayerPrefs.SetString("CurrentPlayerName", currentName);
        PlayerPrefs.SetFloat("CurrentPlayerName", currentScore);

        float tmpScore = 0f;
        string tmpName = "";

        for (int i = 0; i < 3; i++)
        {
            bestScore[i] = PlayerPrefs.GetFloat(i + "BestScore");
            bestName[i] = PlayerPrefs.GetString(i + "BestName");

            while (bestScore[i] < currentScore)
            {
                tmpScore = bestScore[i];
                tmpName = bestName[i];
                bestScore[i] = currentScore;
                bestName[i] = currentName;

                currentScore = tmpScore;
                currentName = tmpName;
            }
        }
        for (int i = 0; i < 3; i++)
        {
            PlayerPrefs.SetFloat(i + "BestScore", bestScore[i]);
            PlayerPrefs.SetString(i.ToString() + "BestName", bestName[i]);
        }
    }
}
