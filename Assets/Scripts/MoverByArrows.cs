using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component is responsible for moving the object using the Arrows keys .
 */

public class MoverByArrows : MonoBehaviour
{

    [SerializeField]
    float step = 0.05f;
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, step, 0);
            Debug.Log("up");
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, step, 0);
            Debug.Log("down");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(step, 0, 0);
            Debug.Log("right");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(step, 0, 0);
            Debug.Log("left");
        }
    }
}