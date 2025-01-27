using UnityEngine;
using UnityEngine.SceneManagement; // For scene management

public class Restart : MonoBehaviour
{
    private bool gameOver = false; // Flag to track game state
    public string currentSceneIndex;

    void Update()
    {
        // Check for restart key if game is over
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the player hits an obstacle
        if (collision.gameObject.CompareTag("Player"))
        {
            RestartGame();
        }
    }

    

    void RestartGame()
    {
        // Option 1: Reload the current scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

        // Option 2: Reset the script's state
        // gameOver = false;
        // Reset player position, variables, etc.
    }
}

