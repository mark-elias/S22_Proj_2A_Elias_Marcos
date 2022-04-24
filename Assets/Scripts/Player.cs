using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector2 targetPositon;

    public float verticalIncrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;


    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPositon, speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPositon = new Vector2(transform.position.x, transform.position.y + verticalIncrement);

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPositon = new Vector2(transform.position.x, transform.position.y - verticalIncrement);
        }
    }
}
