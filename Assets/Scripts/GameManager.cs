using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool isGameEnded = false;
    private int coinCount = 0;
    public Text coinText; 
    private void Start()
    {
        UpdateUI();
    }

    public void EndGame()
    {
        if (isGameEnded == false)
        {
            isGameEnded = true;
            Invoke("Restart", 0f);
        }
    }

    public void RePosition()
    {
       FindObjectOfType<PlayerCarMovement>().repositionPlayer();
      
    }

    public void Restart()
    {
      
        Coins.coinCount=0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    private void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = coinCount.ToString();
        }
    }
}
