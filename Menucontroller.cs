using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menucontroller : MonoBehaviour
{
    public void changescence(string scenceName)
    {
        SceneManager.LoadScene(scenceName);
    }

    public void exitgame()
    {
        Application.Quit();
    }
}
