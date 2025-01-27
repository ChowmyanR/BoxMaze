using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string currentSceneIndex;

    public void LoadNextLevel()
    {
        // Load the next level
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            LoadNextLevel();
        }
    }
}