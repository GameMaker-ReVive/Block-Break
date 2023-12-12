using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SeenLoad : MonoBehaviour
{
    
    public void GameStart(){
        SceneManager.LoadScene("GAME");
        Debug.Log("게임 시작");
    }
    public void Ranking(){
        SceneManager.LoadScene("RANKING");
        Debug.Log("랭킹");
    }
    public void Home(){
        SceneManager.LoadScene("START");
        Debug.Log("홈");
    }
    public void ReStart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("재시작");
    }
}
