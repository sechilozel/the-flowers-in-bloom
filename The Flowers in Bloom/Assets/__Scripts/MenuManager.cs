using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public void NextScene2()
    {
        SceneManager.LoadScene("Falling Flowers and Flowing Water-EASY");
        Time.timeScale = 1;
        // SceneManager.LoadScene("Menu");
    }
    public void BackScene()
    {
        SceneManager.LoadScene("Title");
        Time.timeScale = 1;
    }
}