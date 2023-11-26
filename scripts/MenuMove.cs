using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMove : MonoBehaviour
{
//super simple animation, I love sine, I'll make something fancier when I have the time
    void Update()
    {
        transform.position = transform.position + new Vector3(0,0,Mathf.Sin(Time.fixedTime*2)/1500);
    }
}
