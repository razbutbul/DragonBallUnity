using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed;
    public GameObject topRightLimitGameObject;
    public GameObject BottomLeftLimitGameObject;

    private Vector3 topRightLimit;
    private Vector3 BottomLeft;
    private Vector2 input;



    void Start()
    {
        topRightLimit = topRightLimitGameObject.transform.position;
        BottomLeft = BottomLeftLimitGameObject.transform.position;
    }

    
    void FixedUpdate()
    {

        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if ((transform.position.x <= BottomLeft.x && input.x == -1)|| (transform.position.x >= topRightLimit.x && input.x == 1)) 
        {
            input.x = 0;
        }
        if ((transform.position.y <= BottomLeft.y && input.y == -1) || (transform.position.y >= topRightLimit.y && input.y == 1))
        {
            input.y = 0;
        }
     
        if (Input.GetKey("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,3,0);
        }
        transform.position += new Vector3(speed * input.x, speed * input.y, 0);
    }
}