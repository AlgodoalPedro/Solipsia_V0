using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int playerScore = 0;

    private void Start()
    {
        scoreText.text = playerScore.ToString() + " Skulls";
    }

    void Update(){
        scoreText.text = playerScore.ToString() + " Skulls";
    }
    
    public void AddPoint(){
        playerScore += 1;
        scoreText.text = playerScore.ToString() + " Skulls";
    }

    public int GetPoint(){
        return playerScore;
    }


    public static Score instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Optional if you want persistence
        }
        else
        {
            Destroy(gameObject);
        }
    }


}