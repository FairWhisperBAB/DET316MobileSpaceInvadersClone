using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundyScript : MonoBehaviour
{
    public float minX = -10;
    public float maxX = -10;

    public float minY = -10;
    public float maxY = -10;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX),
            Mathf.Clamp(transform.position.y, minY, maxY), 0);
    }
}
