    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeLife : MonoBehaviour
{
    [SerializeField] int life;
    private PlayerLife playerLife;
    [SerializeField] private GameObject municion;


    private void Awake()
    {
        playerLife= GameObject.Find("Player").GetComponent<PlayerLife>();
    }
    public void CambioVida(int value)
    {

        life = life + value;

        if (life <= 0)
        {
            DropMunicion();
            Destroy(gameObject);
            
        }

    }

    void DropMunicion()
    {
        if (life <= 0)
        {
            GameObject drop = Instantiate(municion);
            drop.transform.position = transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Arma1"))
        {
            CambioVida(-1);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Arma2"))
        {
            CambioVida(-2);
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerLife.CambioVida(-1);
            CambioVida(-1000);
        }
    }



    

    // Update is called once per frame
    void Update()
    {
        
    }
}
