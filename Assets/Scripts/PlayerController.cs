using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;
    
    public float speed = 20f;
    public float turnSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal" + inputID);
        float forwardInput = Input.GetAxis("Vertical" + inputID);
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
