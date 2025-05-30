using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 15.0f;
    private float horizontalInput;
    private float verticalInput;
    private float sideBounds = 23;
    private float turnSpeed = 100.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Player movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //player rotation
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    
        if (transform.position.x < -sideBounds)
        {
            transform.position = new Vector3(-sideBounds, transform.position.y, transform.position.z);
        }

        if (transform.position.x > sideBounds)
        {
            transform.position = new Vector3(sideBounds, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -sideBounds)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -sideBounds);
        }
    }
}
