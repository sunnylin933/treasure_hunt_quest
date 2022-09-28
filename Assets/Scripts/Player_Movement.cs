using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public bool canMove = false;
    public float movespeed = 6.0f;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Movement Determinations
        if(canMove)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            float xspeed = x * (movespeed * Time.deltaTime);
            float yspeed = y * (movespeed * Time.deltaTime);

            transform.position = new Vector3(transform.position.x + xspeed, transform.position.y + yspeed, 0);

            //Sprite Determinations
            if (x < 0)
            {
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
            else if (x > 0)
            {
                this.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (x == 0 && y == 0)
            {
                anim.SetBool("IsMoving", false);
            }
            else
            {
                anim.SetBool("IsMoving", true);
            }

        }

    }
}
