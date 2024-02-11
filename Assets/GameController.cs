using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public int playerScore;
    public int ticks;
    public int tickIncrement;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        ticks = 0;
        tickIncrement = 10;
    }
    public void addScore(int x){
        playerScore += x;
        scoreText.text = playerScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        tickIncrement +=1;
        
        if (tickIncrement == 50){
            ticks +=1;
            tickIncrement = 0;
        }
       
       
    }
}
