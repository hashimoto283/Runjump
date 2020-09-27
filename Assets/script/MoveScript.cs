using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private float STEP = 5.0f;
    private Vector2 velocity;
    public float JUMP_POWER;
    private int MAX_JUMP_COUNT = 2;
    private int jumpCount = 0;
    private bool jump = false;
    Rigidbody2D rb;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {

        this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
        if (jumpCount < MAX_JUMP_COUNT && Input.GetMouseButtonDown(0))
        {
           rb.AddForce(new Vector2(0, JUMP_POWER));
        }
    }
}