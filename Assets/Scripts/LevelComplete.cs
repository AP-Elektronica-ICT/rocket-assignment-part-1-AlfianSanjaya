using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextLevel != 3)
        {
            SceneManager.LoadScene(nextLevel);
        }
        else
        {
            Debug.Log("Game completed");
        }
    }
}
