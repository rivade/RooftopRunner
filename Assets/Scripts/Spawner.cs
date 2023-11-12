using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject enemyCrouching;

    [SerializeField]
    GameObject enemy;

    float timer = 0;
    float timeBetweenEnemies = 2f;

    List<GameObject> enemies = new();

    void Start()
    {
        enemies.Add(enemy);
        enemies.Add(enemyCrouching);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeBetweenEnemies)
        {
            Instantiate(enemies[Random.Range(0, enemies.Count)]);
            timer = 0;
        }
    }
}
