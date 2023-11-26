using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instrReturn : MonoBehaviour
{
    public Button Return;
    // Start is called before the first frame update
    void Start()
    {
        Button  Returnb = Return.GetComponent<Button>();
    }

    // Update is called once per frame
    public void returnTo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Intro");
    }

}
