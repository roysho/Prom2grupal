using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class balaMove : MonoBehaviour
{
    private Vector2 direccion;
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();



    }

    public void Direccion(Vector2 direccion)
    {
        this.direccion = direccion;
    }

    void Movimiento()
    {
        rb2d.velocity = direccion * speed;
    }




    // Update is called once per frame
    void Update()
    {

        Movimiento();
    }
}

