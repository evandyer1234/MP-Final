using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject main, levelselect;

    public void Start()
    {
        back();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Debug.Log("Quit");
        Application.Quit();
    }

    public void ToScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ToLevelSelect()
    {
        main.SetActive(false);
        levelselect.SetActive(true);
    }

    public void back()
    {
        main.SetActive(true);
        levelselect.SetActive(false);
    }
}
