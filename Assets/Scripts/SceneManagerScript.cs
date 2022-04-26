using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // staticv variable

    //public Text valueText; 

    public Text rocketName;


    //public Button PlayGameButton;

    //

    private void Start()
    {
        // valueText.text = PersistentManagerScript.Instance.Value.ToString();

        //rocketName.text = PersistentManagerScript.Instance.rocketName.ToString();

        //SceneManager.LoadScene("Main Scene");
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

    public void BlueButtonClicked()
    {
        PersistentManagerScript.Instance.rocketColor = "Blue";
    }
    public void GreenButtonClicked()
    {
        PersistentManagerScript.Instance.rocketColor = "Green";
    }
    public void PurpleButtonClicked()
    {
        PersistentManagerScript.Instance.rocketColor = "Purple";
    }

}
