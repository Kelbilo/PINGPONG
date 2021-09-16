using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public static int playerOneScore = 0;
    public static int playerTwoScore = 0;

    public Text pOneStxt;
    public Text pTwoStxt;

    Player player;
    OpponentAI oi;

    public void MenuMain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Update is called once per frame
    void Update()
    {
        pOneStxt.text = playerOneScore.ToString();
        pTwoStxt.text = playerTwoScore.ToString();
        
    }

    public static void Score(string wallID)
    {
        if (wallID == "WallRight")
        {
            playerOneScore++;
        }
        else if (wallID == "WallLeft")
        {
            playerTwoScore++;
        }
    }
}
