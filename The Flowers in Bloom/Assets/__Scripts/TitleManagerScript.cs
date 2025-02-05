using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManagerScript : MonoBehaviour
{
    public void NextScene()
    {
        // SceneManager.LoadScene("Falling Flowers and Flowing Water-EASY");
        SceneManager.LoadScene("Menu");
    }
}
