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
    public RankingManager rm;
    public Text score;
    public Text end;
    public Text nick;
    public int scr;
    public string nickname;
    int set = 3;

    public void Awake()
    {
        nickname = PlayerPrefs.GetString("name1");
        Debug.Log(nickname);
        nick.text = "Player : " + nickname;
    }
  
    public void Break(){
       scr += 20;
       ScoreJudge();
    }
    public void Hit(){
        scr += 10;
        ScoreJudge();
    }
    void ScoreJudge(){
        score.text = "Score : " + scr;
    }
    public void Check(){

        if(playerBall[0].activeSelf == false && playerBall[1].activeSelf == false && playerBall[2].activeSelf == false && set == 3 ){
            playerBall[1].SetActive(true);
            playerBallImg[2].SetActive(false);
            Debug.Log("0번 사망");
            set--;
        }
        else if(playerBall[1].activeSelf == false && playerBall[0].activeSelf == false && set == 2){
            playerBall[2].SetActive(true);
            playerBallImg[1].SetActive(false);
            Debug.Log("1번 사망");
            set--;
        }
        else if(playerBall[2].activeSelf == false && playerBall[1].activeSelf == false &&playerBall[0].activeSelf == false && set ==1){
           
            playerBallImg[0].SetActive(false);
            PlayerPrefs.SetString("pname", nickname);
            PlayerPrefs.SetFloat("pscore", scr);

            GameEnd();
            Debug.Log("게임종료");

            
        }

    }
    void GameEnd(){
        reset.SetActive(true);
    }
   
}
