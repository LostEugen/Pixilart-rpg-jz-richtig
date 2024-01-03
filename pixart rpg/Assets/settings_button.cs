
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings_button : MonoBehaviour {
    public void GoToScene(string sceneName) { 
    SceneManager.LoadScene(sceneName);
    }    

    public void QuitApp() {
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}