using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float px;

    // Update is called once per frame
    void Update()
    {
        px = GameObject.Find("player").transform.position.x;
        this.transform.position = new Vector3(px, 0, -20.0f);
    }
}
