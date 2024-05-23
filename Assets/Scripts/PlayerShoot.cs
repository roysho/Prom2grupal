using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    //private Vector2 direction;
    
    private Rigidbody2D rb;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPrefab2;
    
    private Camera cam;
    [SerializeField] int municion1;
    [SerializeField] int municion2;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //playerMovement = GetComponent<PlayerMovement>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }


    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 playerPosition = transform.position;
            Vector2 direction=  mousePosition - playerPosition;
            direction = direction.normalized;
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(direction);
            municion1 -= 1;
            Destroy(obj, 5f);

        }
        else if (Input.GetMouseButtonDown(1))
        {
            Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 playerPosition = transform.position;
            Vector2 direction = mousePosition - playerPosition;
            direction = direction.normalized;
            GameObject obj = Instantiate(bulletPrefab2);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(direction);
            municion2 -= 1;
            Destroy(obj, 5f);
        }



    }
    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
}
