using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{


    //public Text output_rocketName;      // stored

    public GameObject inputField;       // input

    public GameObject textDisplay;      // output
    //--------------------------------------------------

    public GameObject displayHealth;

    // --------------------------------------------------------------
    private void Start()
    {
        // valueText.text = PersistentManagerScript.Instance.Value.ToString();

        //rocketName.text = PersistentManagerScript.Instance.rocketName.ToString();

       // SceneManager.LoadScene("Main Scene");

        textDisplay.GetComponent<Text>().text = PersistentManagerScript.Instance.rocketName.ToString();


        // displaying player health
       
         displayHealth.GetComponent<Text>().text = PersistentManagerScript.Instance.playerHealth.ToString();

        
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

    // ----------- when Rocket Color buttons are selected, 
    // store the color (string) into the Persistent Manager
    // and then change the Sprite in the Player Script
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


    // input for Player name
    public void NameForRocketEntered()
    {
        PersistentManagerScript.Instance.rocketName = inputField.GetComponent<Text>().text;
        Debug.Log("name for rocket has been saved");

        textDisplay.GetComponent<Text>().text = PersistentManagerScript.Instance.rocketName.ToString();
    }

    //----------- Choosing Player Difficulty
    //
    // when difficulty is selected 
    // store the player health (integer) into the Persistent Manager
    // and then change the Value in the Player Script
    public void UserChoseEasy()
    {
        PersistentManagerScript.Instance.playerHealth = 5;
    }
    public void UserChoseMedium()
    {
        PersistentManagerScript.Instance.playerHealth = 3;
    }
    public void UserChoseHard()
    {
        PersistentManagerScript.Instance.playerHealth = 1;
    }



}
