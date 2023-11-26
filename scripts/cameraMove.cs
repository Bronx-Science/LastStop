using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
    {
    // camera will follow this object
    public Transform Target;
    //camera transform
    public Transform camTransform;
    // offset between camera and target
    public Vector3 Offset;
    // change this value to get desired smoothness
    public float SmoothTime = 0.3f;
 
    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;
 
    private void Start()
    {
        camTransform.position= transform.position+Offset;
    }
 
    void LateUpdate()
    {
        transform.position=Target.position;
        transform.RotateAround(Target.position, Vector3.up, Input.GetAxis("Mouse X"));
        transform.RotateAround(Target.position, Vector3.forward, Input.GetAxis("Mouse Y"));
        camTransform.LookAt(Target.position+new Vector3(0,1,0));
    }
}
