using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private Vector2 targetPositon;

    public float verticalIncrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    // player health

    public int health;

    public GameObject displayHealth;

    //sprite array

    // public Sprite[] spriteArray;


    // changing sprite

    public Sprite blueRocket;
    public Sprite greenRocket;
    public Sprite purpleRocket;
    // changing Sprite when player dies
    public Sprite Player_Dead;

    // audio

    public AudioSource source;

    public AudioClip clip;

    public AudioSource source_2;

    public AudioClip clip_rocketMovingSound;
    public void PlayerWantsBlueRocket()
    {
       // this.gameObject.GetComponent<SpriteRenderer>().sprite = Art_Rocket_Blue_4;
    }
    private void PlayerHasDied()
    {
        //PersistentManagerScript.Instance.playerHealth = 0;
        //this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Dead;
        SceneManager.LoadScene("Game Over");



        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Start()
    {
       if (PersistentManagerScript.Instance.rocketColor == "Blue")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = blueRocket;
        }
       else if (PersistentManagerScript.Instance.rocketColor == "Green")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = greenRocket;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = purpleRocket;
        }

        // choosing difficulty

        if (PersistentManagerScript.Instance.playerHealth == 1)
        {
            health = 1;
        }
        else if (PersistentManagerScript.Instance.playerHealth == 3)
        {
            health = 3;
        }
        else
        {
            health = 5;
        }

    

    }


    float pressRate = 0.8f;
    float nextPress = 0.0f;
    private void Update()
    {

       

        if (health <= 0)
        {
            Debug.Log("Player has died");

            this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Dead;

            //SoundManagerScript.playExplosionSound();

            source.PlayOneShot(clip);

            Invoke("PlayerHasDied", 3);
            //PlayerHasDied();
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPositon, speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight && Time.time > nextPress)
        {

            //play sound effect
            source_2.PlayOneShot(clip_rocketMovingSound);

            nextPress = Time.time + pressRate;
            //camAnim.SetTrigger("shake");
            targetPositon = new Vector2(transform.position.x, transform.position.y + verticalIncrement);

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight  && Time.time > nextPress)
        {

            // play sound effect
            source_2.PlayOneShot(clip_rocketMovingSound);

            nextPress = Time.time + pressRate;

            targetPositon = new Vector2(transform.position.x, transform.position.y - verticalIncrement);
        }

     
    }
}
