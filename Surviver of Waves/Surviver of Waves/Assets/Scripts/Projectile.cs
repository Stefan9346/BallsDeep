using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


    public float speed;
    public GameObject enemy;

    private Vector2 target;



    public void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }


    public void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target) <0.5f)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
