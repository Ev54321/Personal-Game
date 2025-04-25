using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Player movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Player turning
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
