using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject enemyAlternate;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        InvokeRepeating("CreateEnemyAlternate", 1f, 5f);
        InvokeRepeating("CreateCoin", 1f, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 8f, 0), Quaternion.identity);
    }

    void CreateEnemyAlternate()
    {
        Instantiate(enemyAlternate, new Vector3(Random.Range(-7f, 7f), 8f, 0), Quaternion.identity);
    }

    void CreateCoin()
    {
        Instantiate(coin, new Vector3(Random.Range(-7f, 7f), 8f, 0), Quaternion.identity);
    }
}
