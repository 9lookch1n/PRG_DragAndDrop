using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 moveVelocity;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveVelocity.x = Input.GetAxisRaw("Horizontal");
        moveVelocity.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", moveVelocity.x);
        anim.SetFloat("Vertical", moveVelocity.y);
        anim.SetFloat("Speed", moveVelocity.sqrMagnitude);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * speed * Time.fixedDeltaTime);
    }
}
