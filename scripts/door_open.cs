using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class door_open : MonoBehaviour
{
    public GameObject left, right;//stores door object
    private Vector3 leftPos, rightPos;//stores door position
    void Start()
    {
        leftPos= left.transform.position;    //assigns doors to var
        rightPos= right.transform.position;
        StartCoroutine(door(leftPos, rightPos,3));
    }

    IEnumerator door(Vector3 Left, Vector3 Right, float duration)
    {
        yield return new WaitForSeconds(2);
        float time= 0;//to store the time
        Vector3 leftS = Left+ new Vector3(0,0,-0.6f);//creates final positions, I have no idea why I named it that
        Vector3 rightS = Right + new Vector3(0,0,.6f);
        while (time < duration)
        {
            left.transform.position = Vector3.Lerp(Left,leftS,time/duration); //uses lerp to move doors
            right.transform.position = Vector3.Lerp(Right,rightS,time/duration);
            time += Time.deltaTime;
            yield return null;
        }
            left.transform.position = leftS; //keeps doors at final position after lerp ends
            right.transform.position = rightS;
    }

    
}
