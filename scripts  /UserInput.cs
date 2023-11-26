using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float speed =3;
    public float turnSpeed =0.5f;
    public Animator anim;
    public LayerMask whatIsGround;
    public float groundDistance = 0.3f;
    public Main game;
    public int item,max;
    void Start(){
        Cursor.lockState =  CursorLockMode.Locked;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");//gets mouse axis
        float f = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h,0,f)*speed*Time.deltaTime);//moves player
        anim.SetFloat ("speed",f+h);//animation for player
        float turn = Input.GetAxis("Mouse X");//turning
        transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X"));
        if (Input.GetButtonDown ("Jump")){
            transform.Translate(Vector3.up*2);
            anim.SetTrigger ("Jump");
        }
        if (Physics.Raycast (transform.position + (Vector3.up * 0.1f), Vector3.down, groundDistance, whatIsGround)) 
        {
        anim.SetBool ("grounded", true);
        anim.applyRootMotion = true;
        } 
        else {
        anim.SetBool ("grounded", false);
        }
    }
    void  OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("collect")){
            other.gameObject.SetActive(false);
            game.items+=1;
        }
        if (other.gameObject.CompareTag("water")){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Endlose");
        }
        if (other.gameObject.CompareTag("door")&&(game.getItems()>=game.getMax())){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Endwin");
        }
    }
}
