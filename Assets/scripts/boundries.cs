using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component gives boundries to the object we will return the object to the center
 * of the map as soon as he reaches his limit.
 */
public class boundries : MonoBehaviour
{
    float scaleX;
    float scaleY;
    float rightLimit = 6.3f;
    float leftLimit = -8.4f;
    float topLimit = 5.5f;
    float bottomLimit = -6.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scaleX = transform.position.x;
        scaleY = transform.position.y;
        if (scaleX > rightLimit )
        {
            transform.position = new Vector3(rightLimit, scaleY, 0);
        }
        if ( scaleX < leftLimit)
        {
            transform.position = new Vector3(leftLimit, scaleY, 0);
        }
        if (scaleY > topLimit)
        {
            transform.position = new Vector3(scaleX, topLimit, 0);
        }
        if (scaleY < bottomLimit)
        {
            transform.position = new Vector3(scaleX, bottomLimit, 0);
        }
    }
}
