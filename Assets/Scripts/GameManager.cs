using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    [SerializeField] float restartDelay = 1f;
    public GameObject completeLevelUI;
    
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextLevel != 2)
        {
            SceneManager.LoadScene(nextLevel);
        } else
        {
            Debug.Log("Game completed");
        }
       
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
