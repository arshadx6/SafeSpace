using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{

    public void LaunchSpace(){
        SceneManager.LoadScene("MenuforScenes");
    }
    public void LaunchHelp(){
        SceneManager.LoadScene("HelpS");
    }
    public void QuitApp(){
        Application.Quit();
    }
     public void Back(){
        SceneManager.LoadScene("UI");
    }
}
