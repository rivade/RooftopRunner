using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorpseMover : MonoBehaviour
{
    void Update()
    {
        Vector2 movement = Vector2.left * EnemyController.speed * Time.deltaTime;
        transform.Translate(movement);
        if (transform.position.x < Camera.main.orthographicSize - 25)
        {
            Destroy(this.gameObject);
        }
    }
}
