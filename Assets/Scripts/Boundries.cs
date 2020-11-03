using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component gives boundries to the object we will return the object to the center
 * of the map as soon as he reaches his limit.
 */
public class Boundries : MonoBehaviour
{
    float rightLimit;

    float leftLimit;

    float topLimit;

    float bottomLimit;

    // Start is called before the first frame update
    void Start()
    {
        GameObject mazeObject = GameObject.Find("Maze");
        Transform mazeTransform = mazeObject.GetComponent<Transform>();
        RectTransform mazeRect = mazeObject.GetComponent<RectTransform>();

        float mazeWidth = mazeRect.rect.width;
        float mazeHeight = mazeRect.rect.height;
        float mazeScaleX = mazeRect.transform.localScale.x;
        float mazeScaleY = mazeRect.transform.localScale.y;

        rightLimit = ( (mazeWidth * mazeScaleX) / 2 - mazeScaleX / (mazeWidth * 2) );
        leftLimit = -1 * rightLimit;

        topLimit = ( (mazeHeight * mazeScaleY) / 2 - mazeScaleY / (mazeHeight * 2) );
        bottomLimit = -1 * topLimit;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, leftLimit, rightLimit);
        pos.y = Mathf.Clamp(pos.y, bottomLimit, topLimit);
        transform.position = pos;
    }
}


