using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RankingManager : MonoBehaviour
{
    public float[] bestScore = new float[10];
    public string[] bestName = new string[10];
    public Text[] rank;
    public void ScoreSet(float currentScore, string currentName)
    {
        PlayerPrefs.SetString("CurrentPlayerName", currentName);
        PlayerPrefs.SetFloat("CurrentPlayerName", currentScore);

        float tmpScore = 0f;
        string tmpName = "";

        for (int i = 0; i < 10; i++)
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
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetFloat(i + "BestScore", bestScore[i]);
            PlayerPrefs.SetString(i.ToString() + "BestName", bestName[i]);
        }
    }
}
