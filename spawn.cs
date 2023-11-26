using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject can, lemon;
    private GameObject[] cans = new GameObject[5];
    private GameObject[] lemons = new GameObject[5];
    private Vector3[] pos = new Vector3[]{
        new Vector3(30,-.5f,40),new Vector3(28,-.5f,35.5f),
        new Vector3(43,0,35),new Vector3(38,0,39),
        new Vector3(54,-4,29),new Vector3(43,-4,32),
        new Vector3(39,-3.8f,25),new Vector3(36,-2,23),
    };
    void Start()
    {
        int[] nums = new int[8];
        for (int x = 0; x<5; x++){
            int ran = Random.Range(0,7);
            while (nums[ran]==1){
                ran = Random.Range(0,7);
            }
            cans[x]= Instantiate(can);
            cans[x].transform.position= pos[ran];
            nums[ran]=1;
            lemons[x] = Instantiate(lemon);
            float ranx = (float)(31+Random.Range(0,10));
            float rany = (float)(2+Random.Range(0,9));
            lemons[x].transform.position=new Vector3(ranx, -2, rany);
        }

    }
}
