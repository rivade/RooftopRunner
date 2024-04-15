using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    private bool isJumping = false;

    public float jumpPower;

    private Rigidbody2D rb;

    private Animator anim;

    private AudioSource audioSource;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping && !anim.GetBool("isShielding")){
            rb.AddForce(new Vector2(0, jumpPower));
            audioSource.Play();
        }
    }


    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Floor"))
        {
            anim.SetBool("isJumping", false);
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Floor"))
        {
            anim.SetBool("isJumping", true);
            isJumping = true;
        }
    }
}
