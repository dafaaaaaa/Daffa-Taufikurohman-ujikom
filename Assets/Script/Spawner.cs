using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] animals;
    public float spawnInterval = 2f;
    void Start()
    {
        StartCoroutine(SpawnAnimal());
    }

    IEnumerator SpawnAnimal()
    {
        while (true)
        {
            Instantiate(animals[Random.Range(0, animals.Length)], transform.position, transform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
