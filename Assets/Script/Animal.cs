using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float speed;
    public int hunger;
    public int scoreValue;

    public int currentHunger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            currentHunger += 25;
            Destroy(other.gameObject);
            if (currentHunger >= hunger)
            {
                GameManager.Instance.AddScore(scoreValue);
                Destroy(gameObject);
            }
        }
    }
}
