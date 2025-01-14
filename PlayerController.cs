using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 15.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Player input.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward.
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        //Turn vehicle based on horizontal input.
        transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed*horizontalInput);
    }
}
