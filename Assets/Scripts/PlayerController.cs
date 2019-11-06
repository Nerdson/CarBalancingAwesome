using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // define variables, variables consist of:
    // access modifier  data type   variable name   variable value
    public float speed = 25; 
    public float turnSpeed = 45;
    public float horizontalInput; 
    public float forwardInput;

    // float = Dezimalzahl - 1.0f, 1.5f usw
    // int = integer = Ganzzahlen - 1, 2, 3, 4 usw
    // bool = boolean = true / false

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        // move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}