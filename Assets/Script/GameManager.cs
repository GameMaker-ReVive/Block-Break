using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject[] playerBall;
    public GameObject[] playerBallImg;
    public GameObject[] block;
    public GameObject reset;
    public Text score;
    public Text end;
    public int scr;
    void Update(){
        
        Break();
    }
    void Break(){
       
    }
    void ScoreJudge(){
        score.text = "Score : " + scr;
    }
    public void Check(){
        if(playerBall[0].activeSelf == false){
            playerBall[1].SetActive(true);
            playerBallImg[2].SetActive(false);
            Debug.Log("0번 사망");
        }
        else if(playerBall[1].activeSelf == false &&playerBall[0].activeSelf == false){
            playerBall[2].SetActive(true);
            playerBallImg[1].SetActive(false);
            Debug.Log("1번 사망");
        }
        else if(playerBall[2].activeSelf == false && playerBall[1].activeSelf == false &&playerBall[0].activeSelf == false){
           
            playerBallImg[0].SetActive(false);
            GameEnd();
            Debug.Log("게임종료");
        }
    }
    void GameEnd(){
        reset.SetActive(true);
    }
   
}
