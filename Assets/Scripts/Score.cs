using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int currentScore = 0;
    public GameObject scoreText;

    private void Start()
    {
        if (scoreText == null)
        {
            Debug.Log("No reference to scoreText");
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = currentScore.ToString();
        //scoreText.GetComponent<Text>().text = currentScore.ToString();
    }
}
