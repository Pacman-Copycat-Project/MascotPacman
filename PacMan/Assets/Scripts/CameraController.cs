using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Camera thisCamera;
    public Camera otherCamera;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            thisCamera.enabled = true;
            otherCamera.enabled = false;
        }
    }
}
