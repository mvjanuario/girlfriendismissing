using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public Rigidbody2D rb;
    public Animator anim;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (movement.y != 0) {
            if (movement.y > 0){
                anim.SetBool("WalkingBack", true);
            }
            else {
                anim.SetBool("WalkingFront", true);
            }
        }
        else {
            anim.SetBool("WalkingFront", false);
            anim.SetBool("WalkingBack", false);
        }

        if (movement.x != 0) {
            anim.SetBool("WalkingHorizontal", true);
            if (movement.x > 0) {
                gameObject.transform.localScale = new Vector3(-1, 1, 1);
            }
            else {
                gameObject.transform.localScale = new Vector3(1, 1, 1);
            }
        }
        else {
            anim.SetBool("WalkingHorizontal", false);
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
