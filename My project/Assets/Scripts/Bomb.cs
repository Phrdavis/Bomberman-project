using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public float tempoDeExplosão;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explodir", tempoDeExplosão);
    }

    void Explodir()
    {
        Destroy(gameObject);
    }
}
