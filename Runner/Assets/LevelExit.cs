using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something entered: " + collision.gameObject.name);
        
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
