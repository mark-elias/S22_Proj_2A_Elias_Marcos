using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    // -------------------

    public int damage = 1;

    public float speed;

    //

    private void Update()
    {

        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") )
        {
            // player takes damage

            other.GetComponent<Player>().health -= damage;

            

            Debug.Log(other.GetComponent<Player>().health);

            //SoundManagerScript.playExplosionSound();


            Destroy(gameObject);


        }


    }

}
