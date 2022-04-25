using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

    public Text valueText; 


    //public Button PlayGameButton;

    //

    private void Start()
    {
       // valueText.text = PersistentManagerScript.Instance.Value.ToString();
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Main Scene");

        // updating STATIC variable
        //PersistentManagerScript.Instance.Value++;

    }

    public void GoToPlayScene()
    {

        Debug.Log("GoToPlayScene");
        SceneManager.LoadScene("Play Scene");

        // updating the STATic variable
        //PersistentManagerScript.Instance.Value++;
    }

    public void GoToGameOverScene()
    {
        Debug.Log("game over scene called");

        SceneManager.LoadScene("Game Over");

    }

}
