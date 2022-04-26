using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class RocketNameTransfer : MonoBehaviour
{

    // -----------------------

    //public Text output_rocketName;      // stored

    public GameObject inputField;       // input

    public GameObject textDisplay;      // output


    // --------------------------------------------------------------



    // taking user input for Rocket Name
    // and then saving it in our Persistent Manager


    public void NameForRocketEntered()
    {
        PersistentManagerScript.Instance.rocketName = inputField.GetComponent<Text>().text;
        Debug.Log("name for rocket has been saved");

        textDisplay.GetComponent<Text>().text = PersistentManagerScript.Instance.rocketName.ToString();
    }



}
