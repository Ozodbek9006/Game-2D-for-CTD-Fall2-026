using UnityEngine;
using TMPro;

public class Collector : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            score++;
            if (scoreText) scoreText.text = "Score: " + score;
            Destroy(other.gameObject);
        }
    }
}