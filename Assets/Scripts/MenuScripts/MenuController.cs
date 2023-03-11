using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
<<<<<<< HEAD
=======
    bool Pressed = false;
>>>>>>> ee04cdd (Début du menu et credit)

    private void Start()
    {
       
    }

    public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ReloadLvl(string _sceneName)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(_sceneName);
    }
    
}
