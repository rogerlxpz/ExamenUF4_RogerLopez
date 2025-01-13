using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public static GameManager gameManager;
public int Coins = 0;
    
    private void Awake()
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this)
            Destroy(gameObject);
        else{
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    public void CoinCollected()
    {
        Coins++;
    }
}
