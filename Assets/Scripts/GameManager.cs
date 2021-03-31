using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject score;
    Text scoreText;

    public void CompleteLevel()
    {
        Debug.Log("Trigger complete level");
        if (score != null)
            scoreText = score.GetComponent<Text>();
        scoreText.text = Score.currentScore.ToString();
        completeLevelUI.SetActive(true);  
    }

    public void Restart()
    {
        Debug.Log("Restart level");
        AudioManager.Instance.Play("RocketDead");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
