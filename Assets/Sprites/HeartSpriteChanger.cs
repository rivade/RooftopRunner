using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpriteChanger : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite threeHearts;

    [SerializeField]
    Sprite twoHearts;

    [SerializeField]
    Sprite oneHeart;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void UpdateHearts(int hearts)
    {
        switch (hearts)
        {
            case 3:
                spriteRenderer.sprite = threeHearts;
                break;

            case 2:
                spriteRenderer.sprite = twoHearts;
                break;

            case 1:
                spriteRenderer.sprite = oneHeart;
                break;
        }
    }
}
