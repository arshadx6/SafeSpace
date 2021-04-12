using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void LaunchSpaceBed(){
        SceneManager.LoadScene("bedroom");
    }
     public void LaunchSpaceCoffee(){
        SceneManager.LoadScene("coffee");
    }
     public void LaunchSpacePark(){
        SceneManager.LoadScene("park");
    }
     public void LaunchBack(){
        SceneManager.LoadScene("UI");
    }

}
