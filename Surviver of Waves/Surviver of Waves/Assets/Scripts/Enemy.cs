using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float speed;
    public GameObject effect;
    public GameObject effectSmaller;
    public float enemyHealth = 5;
    public GameObject sceneManager;
    public bool canDie;
    public GameObject circleTimeUp;
    public GameObject smallGreenEnemy;
    




    private Player player;
    private Transform playerPos;


    public void Start()
    {
        
        canDie = false;
        circleTimeUp = GameObject.Find("CircleTimeUp");
        sceneManager = GameObject.Find("SceneManager");
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

      
    }


    public void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

       
     
    }


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("deathCircle"))
            canDie = true;


        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            player.health--;
            Destroy(gameObject);
            //enemyHealth--;
        }
        if (canDie)
        {
            if (other.CompareTag("Projectile"))
            {
                Instantiate(effectSmaller, transform.position, Quaternion.identity);
                Destroy(other.gameObject);
                //Destroy(gameObject);
                enemyHealth--;
            }
        }

        if (enemyHealth <= 0)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            //Instantiate(circleTimeUp);
            sceneManager.GetComponent<Points>().points++;
            Destroy(gameObject);    

            if (other.CompareTag("EnemyGreen"))
            {
                Instantiate(smallGreenEnemy);
            }
        }

    

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("deathCircle"))
            canDie = false;
    }

}
