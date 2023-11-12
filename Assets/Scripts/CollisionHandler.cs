using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private int hp = 3;
    public static bool isShielding = false;
    private bool isInvincible = false;
    private Animator anim;
    private SpriteRenderer rndr;
    private Color spriteColor;

    [SerializeField]
    HeartSpriteChanger heartSpriteChanger;

    [SerializeField]
    EnemyController enemyController;

    [SerializeField]
    float shieldDuration;

    [SerializeField]
    float invincDuration;

    void Start()
    {
        anim = GetComponent<Animator>();
        rndr = GetComponent<SpriteRenderer>();
        spriteColor = rndr.color;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && !isShielding && !anim.GetBool("isJumping"))
        {
            if (!isInvincible)
            {
                isShielding = true;
                anim.SetBool("isShielding", true);
                StartCoroutine(ShieldTimer());
            }
        }
    }

    IEnumerator ShieldTimer()
    {
        yield return new WaitForSeconds(shieldDuration);

        isShielding = false;
        anim.SetBool("isShielding", false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isInvincible)
        {
            switch (other.gameObject.tag)
            {
                case "StandingEnemy":
                    if (!isShielding)
                    {
                        Hurt();
                    }
                    else
                    {
                        EnemyController enemy = other.GetComponent<EnemyController>();
                        enemy.KillEnemy();
                    }
                    break;

                case "CrouchingEnemy":
                    Hurt();
                    break;
            }
        }
    }

    private void Hurt()
    {
        hp--;
        heartSpriteChanger.UpdateHearts(hp);
        StartCoroutine(InvincibilityFrames());
        if (hp <= 0)
        {
            SceneHandler.GoToScene(3);
        }
    }

    IEnumerator InvincibilityFrames()
    {
        isInvincible = true;
        spriteColor.a = 0.5f;
        rndr.color = spriteColor;

        yield return new WaitForSeconds(invincDuration);

        isInvincible = false;
        spriteColor.a = 1;
        rndr.color = spriteColor;
    }

}