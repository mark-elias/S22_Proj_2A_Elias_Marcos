using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{

    public static PersistentManagerScript Instance { get; private set; }


    // value that we want to keep throught all scenes
    // static variable

   // public int Value;

    //public Sprite player; 


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

}
