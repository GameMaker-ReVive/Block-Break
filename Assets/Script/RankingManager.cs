using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RankingManager : MonoBehaviour
{
    public Text[] rank;
    public List<int> scores = new List<int>();

    void Awake(){
        
     
       

    }
    public void AddScore(int src){
        Debug.Log("AA");
        scores.Add(src);
        Rank();
    }
    void Rank(){
        scores.Sort();
        Ranking();
    }
    void Ranking(){
        int end = 10;
        foreach (int score in scores)
        {
            rank[0].text = score + "위 : " + scores;
            if(end == 0){
                end = 10;
                break;
            }
        }
        
    }
}
