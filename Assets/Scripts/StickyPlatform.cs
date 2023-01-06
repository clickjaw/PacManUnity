using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
     if(collision.gameObject.name == "PacMan")
        {   //when you land on platform you are a child of the parent platform. You stick.
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "PacMan")
        {
            //once you leave the platform the sticky is nulled
            collision.gameObject.transform.SetParent(null);
        }
    }
}
