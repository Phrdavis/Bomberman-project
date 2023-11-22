using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{

    public GameObject bombPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            spawnBomb();
        }
    }

    void spawnBomb()
    {

        Vector2 playerPosition = transform.position;
        Instantiate(bombPrefab, playerPosition, Quaternion.identity);

    }
}
