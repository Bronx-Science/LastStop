using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private int min,sec,remain,next;
    public string Text,secS;
    private static int maxItems=6;
    private int itemsCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        remain=300;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>=next){
            next=Mathf.FloorToInt(Time.time)+1;
            remain-=1; 
            min=remain/60;
            sec=remain%60;
            if (sec<10){
                secS="0"+sec.ToString();
            }
            else{
              secS=sec.ToString();
            }    
        }
      
    
 
        if (remain==0){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Endlose");
        }
    }
    public int items{
        get {return itemsCollected;}
        set { itemsCollected = value;
            Text = "Item found";
        }
    }

    public int getItems(){
        return itemsCollected;
    }

    public int getMax(){
        return maxItems;
    }

    public void OnGUI(){
        GUIStyle style = new GUIStyle();
        style.fontSize=40;
        GUI.Box(new Rect(20,50,300,90), "Item Collected: " + itemsCollected + "/"+maxItems, style);
        GUI.Label(new Rect(Screen.width/2,50,300,50), Text, style);
        GUI.Label(new Rect(Screen.width-100,50,300,90), min.ToString()+":"+secS, style);
    }
    }
