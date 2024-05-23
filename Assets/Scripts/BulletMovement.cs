using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement  : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 direction;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    private void Movimiento()
    {
        rb.velocity = direction * speed;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

    }



}
