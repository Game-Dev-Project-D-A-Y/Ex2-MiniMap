using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component allows us to control the movment of the object with the keyboard arrows
 */

public class MoverByKeyBoard : MonoBehaviour
{
    //step represents the distance of the movment
    [SerializeField]
    float step = 0.01f;
    float scaleX;
    float scaleY;
    void Start()
    {
        //the current position of this object
        scaleX = transform.position.x;
        scaleY = transform.position.y;
    }

    void Update()
    {
        //getkey function allows movment when the key is being pressed for a while
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, step, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, step, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(step, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(step, 0, 0);
            
        }
       
    }
}


