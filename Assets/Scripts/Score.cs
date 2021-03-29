using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int currentScore;
    public GameObject score;
    Text scoreText;

    //Text scoreText;

    private void Start()
    {
        if (score != null)
            scoreText = score.GetComponent<Text>();
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreText != null)
            scoreText.text = currentScore.ToString();
    }
}
