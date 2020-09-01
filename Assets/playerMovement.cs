using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed; //Speed the player moves at.
    private Rigidbody2D rb; //reference to rigidbody in inspector

   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //accessing rigidbody component in inspector
    }


    void Update()
    {
        Movement();
    }

    /// Basic Player Movement down here
    void Movement()
    {
        rb.MovePosition(rb.position + new Vector2(Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.fixedDeltaTime));
    }
    /// 
    /// 
}
