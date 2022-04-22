using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Animation : MonoBehaviour
{


    public Sprite s2;
    public Sprite s3;
    public Sprite s4;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = s2;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = s3;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = s4;


    }
}
