using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    private void OnEnable()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;

    }
    public void Resume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}