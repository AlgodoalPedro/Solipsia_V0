using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;
    [SerializeField] bool finalLevel;
    [SerializeField] int pointsToWin;

    private int currentScore;
    private Score score;

    private void Start()
    {
        score = Score.instance; // Get the singleton instance
        if (score == null)
        {
            Debug.LogError("Score instance not found! Make sure Score script is in the scene and initialized.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (goNextLevel && !finalLevel)
            {
                GameManager.instance.NextLevel();
            }
            else if (finalLevel)
            {
                currentScore = score.GetPoint();
                if (currentScore >= pointsToWin)
                {
                    GameManager.instance.LoadScene("Victory");
                }
                else
                {
                    GameManager.instance.LoadScene("Defeat");
                }
            }
            else
            {
                GameManager.instance.LoadScene(levelName);
            }
        }
    }
}
