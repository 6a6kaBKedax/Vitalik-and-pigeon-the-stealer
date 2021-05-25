using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void Startpressed()
    {
        SceneManager.LoadScene(1);
        Debug.Log("1");
    }
    public void Retrypressed() 
    {
        SceneManager.LoadScene(1);
    }
    public void homepressed() 
    {
        SceneManager.LoadScene(0);
    }
    public void Exitpressed() 
    {
        Application.Quit();
    }
}
