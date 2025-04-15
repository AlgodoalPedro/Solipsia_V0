using UnityEngine;

public class PointCollectible : MonoBehaviour
{
    public Score score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            score.AddPoint();
            gameObject.SetActive(false);
        }
    }

}