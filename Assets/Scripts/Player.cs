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

    public int health = 3;

    //sprite array

    // public Sprite[] spriteArray;


    // changing sprite

    public Sprite blueRocket;
    public Sprite greenRocket;
    public Sprite purpleRocket;
    // changing Sprite when player dies
    public Sprite Player_Dead;

    // effects
    //public Animator canAim;


    // private void PlayerAnimation()
    //  {

    //      Debug.Log("Player animation called");
    //      int i = 0;
    //     this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[i];
    //     i++;
    //if (i == 3)
    //{
    //    Debug.Log("array reset");
    //    i = 0;
    // }

    //}
    public void PlayerWantsBlueRocket()
    {
       // this.gameObject.GetComponent<SpriteRenderer>().sprite = Art_Rocket_Blue_4;
    }
    private void PlayerHasDied()
    {
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
    }
    private void Update()
    {

        

        if (health <= 0)
        {
            Debug.Log("Player has died");

            //health = 3;
            //PlayerHasDied();
           this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Dead;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


            Invoke("PlayerHasDied", 1);
            //PlayerHasDied();
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPositon, speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            //camAnim.SetTrigger("shake");
            targetPositon = new Vector2(transform.position.x, transform.position.y + verticalIncrement);

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPositon = new Vector2(transform.position.x, transform.position.y - verticalIncrement);
        }

     
    }
}
