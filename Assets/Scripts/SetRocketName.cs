using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SetRocketName : MonoBehaviour
{

    // -----------------------

    //public Text output_rocketName;      // stored

    //public GameObject inputField;       // input

    public GameObject textDisplay;      // output


    // --------------------------------------------------------------



    // taking user input for Rocket Name
    // and then saving it in our Persistent Manager

    private void Start()
    {
        textDisplay.GetComponent<Text>().text = PersistentManagerScript.Instance.rocketName.ToString();
    }
}
    //public void DisplayRocketName()
    //{
        //PersistentManagerScript.Instance.rocketName = inputField.GetComponent<Text>().text;
        //Debug.Log("name for rocket has been saved");

       // textDisplay.GetComponent<Text>().text = PersistentManagerScript.Instance.rocketName.ToString();
    //}



//}
