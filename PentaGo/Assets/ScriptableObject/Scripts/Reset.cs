using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    int currentScene;
    private void Start() {
        currentScene=SceneManager.GetActiveScene().buildIndex;
    }

    public void RestartScene(){
        SceneManager.LoadScene(currentScene);
    }

}
