using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private float STEP = 5.0f;
    Rigidbody2D rigid2D;
    private Vector2 velocity;
    public float JUMP_POWER;
    private int MAX_JUMP_COUNT = 2;
    private int jumpCount = 0;
    private bool jump = false;
    [SerializeField] ContactFilter2D filter2d;

    // Update is called once per frame
    void Update()
    {
        if (jumpCount < MAX_JUMP_COUNT && Input.GetMouseButtonDown(0))
        {
            jump = true;
        }
        if (jump)
        {
            // 速度をゼロにして、2回目のジャンプも1回目と同じ挙動にする
            this.rigid2D = GetComponent<Rigidbody2D>();
            rigid2D.velocity = Vector2.zero;

            //ジャンプさせる
            this.rigid2D.AddForce(transform.up * JUMP_POWER);

            //ジャンプ回数をカウント
            jumpCount++;

            jump = false;
        }
    }
}