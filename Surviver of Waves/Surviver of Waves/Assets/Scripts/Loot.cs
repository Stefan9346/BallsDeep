using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour {

    public GameObject deathCircle;
    public GameObject effect;



    public void Start()
    {
        deathCircle = GameObject.Find("deathCircle");
    }





    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            deathCircle.transform.localScale += new Vector3(5f, 5f, 0);
            Destroy(gameObject);
        }
     

    }


    



}
