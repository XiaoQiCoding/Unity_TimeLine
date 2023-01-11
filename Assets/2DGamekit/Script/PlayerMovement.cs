using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BulletHell
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed;
        private Vector2 input;
        private Animator animator;
        private Rigidbody2D rigibody;
        private int gunNum;
        void Start()
        {
            animator = GetComponent<Animator>();
            rigibody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            input.x = Input.GetAxisRaw("Horizontal");
            // input.y = Input.GetAxisRaw("Vertical");

            rigibody.velocity = input.normalized * speed;


            if (input != Vector2.zero)
                animator.SetBool("isMoving", true);
            else
                animator.SetBool("isMoving", false);
        }


    }
}