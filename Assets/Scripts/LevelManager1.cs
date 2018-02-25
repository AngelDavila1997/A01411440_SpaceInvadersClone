using UnityEngine;
using UnityEngine.SceneManagement;		// Requiered to switch scenes
using System.Collections;

public class LevelManager1 : MonoBehaviour
{

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        //	Application.LoadLevel (name);    -- This method was deprecated a long time ago
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
    public void LoadNextLevel()
    {
        //  Load the next scene in the build order
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
