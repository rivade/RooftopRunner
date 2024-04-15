using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    public static float speed = 7;

    [SerializeField]
    GameObject deadEnemy;


    void Start()
    {
        Vector3 pos = new(11.55f, -1.2892f, -5.5f);
        transform.position = pos;
    }

    void Update()
    {
        speed += 0.001f;
        Vector2 movement = Vector2.left * speed * Time.deltaTime;
        transform.Translate(movement);
        if (transform.position.x < Camera.main.orthographicSize - 25)
        {
            Destroy(this.gameObject);
        }
    }

    public void KillEnemy()
    {
        Instantiate(deadEnemy, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
