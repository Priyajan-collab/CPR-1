using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class patrol : MonoBehaviour
{
    public float speed;
    public bool movementright = true;
    public Transform grounddetection;
    public float length;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundCheck = Physics2D.Raycast(grounddetection.position, Vector2.down, length);
        if (groundCheck.collider == false)
        {
            if (movementright == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movementright = false;


            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movementright = true;
            }

        }



    }
}

