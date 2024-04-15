using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed;

    [SerializeField]
    Renderer bgRenderer;

    void Update()
    {
        speed += 0.00005f;
        bgRenderer.material.mainTextureOffset += new Vector2(speed*Time.deltaTime, 0);
    }
}
