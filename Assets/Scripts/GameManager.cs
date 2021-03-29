using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    [SerializeField] float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject score;
    Text scoreText;

    public void CompleteLevel()
    {
        if (score != null)
            scoreText = score.GetComponent<Text>();
        scoreText.text = Score.currentScore.ToString();
        completeLevelUI.SetActive(true);  
    }

    public void EndGame()
    {
        if (gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
