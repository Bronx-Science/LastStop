using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problemChild : MonoBehaviour
{
    //this script is called problem child because it took me way to long to debug this and it's less 10 lines of actual code after clean up :')

    void Start()
    {
        StartCoroutine(loadMain()); 
    }

    IEnumerator loadMain(){
        yield return new WaitForSeconds(9);//waits a bit
        bool run = true;//argument so this only runs once
        if (run==true){
        run=false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        }
    }
}
