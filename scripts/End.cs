using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public Button start, instructions, settings;
    // Start is called before the first frame update
    void Start()
    {
        Button Start = start.GetComponent<Button>();
        Button Instruction = instructions.GetComponent<Button>();
        Button Settings = settings.GetComponent<Button>();
        Cursor.lockState =  CursorLockMode.None;
    }

    // Update is called once per frame
    public void gameStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TransitionIn");//loads the transition
    }

    public void Instrc(){
        Application.Quit();
    }

    public void Settings(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instructions");//loads settings, but really the instuction because I havent made a settings panel
    }
}
