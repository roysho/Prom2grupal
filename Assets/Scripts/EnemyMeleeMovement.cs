using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMeleeMovement : MonoBehaviour
{
    private Rigidbody2D rb2;
    [SerializeField] private float speed;
    [SerializeField] private float followDistance;
    private Transform targetTransform;



    private void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
        targetTransform= GameObject.Find("Player").GetComponent<Transform>();
    }

    void Move()
    {
        if (Vector2.Distance(targetTransform.position, rb2.position) < followDistance)
        {
            Vector2 direction = targetTransform.position - transform.position;
            direction = direction.normalized;
            rb2.velocity = direction * speed;

        }
        else
        {
            rb2.velocity = Vector2.zero;
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        Move();   
    }
}
