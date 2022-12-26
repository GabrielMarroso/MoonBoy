using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float scrollSpeed = 10f;
    void Start()
    {
        rb2d.velocity = new Vector2(scrollSpeed, 0);
    }

    
}
