using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    bool paused = false;
    public GameObject winscreen;
    public GameObject Menu;
    bool won = false;

    void Start()
    {
        Time.timeScale = 1f;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!won)
            {
                if (!paused)
                {
                    Pause();
                }
                else
                {
                    UnPause();
                }
            }
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        Menu.SetActive(true);
        paused = true;
    }
    public void UnPause()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }
    public void Win()
    {
        winscreen.SetActive(true);
        Time.timeScale = 0f;
        won = true;
    }
    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
    public void ToScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
