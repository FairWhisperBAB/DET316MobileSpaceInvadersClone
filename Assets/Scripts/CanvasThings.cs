using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasThings : MonoBehaviour
{
    public GameObject PauseMenu;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Pause()
    {
        Time.timeScale = 0f;

        PauseMenu.SetActive(true);
    }

    public void UnPause()
    {
        Time.timeScale = 1f;

        PauseMenu.SetActive(false);
    }

}