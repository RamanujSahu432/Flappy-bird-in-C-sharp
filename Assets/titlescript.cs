using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlescript : MonoBehaviour
{

    private Rigidbody2D birdrb;
   
    public void playgame()
    {
        Debug.Log("play");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("playexecuted");
       
    }
    public void quitgame()
    {
        Debug.Log("quit");
        Application.Quit();
        Debug.Log("quitexecuted");
    }
    public void options()
    {

        SceneManager.LoadScene("options");

    }
    public void back()
    {

        SceneManager.LoadScene("title");

    }









}
