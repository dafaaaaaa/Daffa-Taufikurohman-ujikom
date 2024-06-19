using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject Food;
    public Transform throwPoint;


    public Animator animator;

    void Start()
    {
    }

    void Update()
    {
        MovePlayer();
        if (Input.GetMouseButtonDown(0))
        {
            ThrowFood();
        }
    }
    void MovePlayer()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 newPosition = transform.position + new Vector3(move,0,0);
        transform.position = newPosition;

        if (move > 0)
        {
            animator.SetBool("Walk", true);
        }
        else if (move < 0)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }

    public void ThrowFood()
    {
        animator.SetTrigger("Throw");
        Instantiate(Food, throwPoint.position, throwPoint.rotation);
    }
}
