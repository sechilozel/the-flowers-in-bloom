using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public void NextScene2()
    {
        SceneManager.LoadScene("Falling Flowers and Flowing Water-EASY");
        // SceneManager.LoadScene("Menu");
    }
}