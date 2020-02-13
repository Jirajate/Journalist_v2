using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private float currentMoveSpeed;
    //public float diagonalMoveModifier;

    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMove;
    private Vector2 moveInput;

    private Rigidbody2D myRigidbody;

    public bool canMove;

    AudioSource audioSrc;

    private void Start()
    {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        audioSrc = GetComponent<AudioSource>();

        canMove = true;
    }

    void Update()
    {
        playerMoving = false;

        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            return;
        }

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (moveInput != Vector2.zero)
        {
            myRigidbody.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
            playerMoving = true;
            lastMove = moveInput;

            if (!audioSrc.isPlaying)
            {
                audioSrc.Play();
            }

        }
        else
        {
            myRigidbody.velocity = Vector2.zero;
            audioSrc.Stop();
        }
        
        anim.SetFloat("MoveX",Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

        anim.SetBool("PlayerMoving",playerMoving);
        anim.SetFloat("LastMoveX",lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

    }
}
