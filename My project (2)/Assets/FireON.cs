using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class FireON : MonoBehaviour
{
    string latestMessageSwitch;
    string latestMessageFire;
    public GameObject fire;
    public float number;
    public GameObject fire1;
    // Start is called before the first frame update
    void Start()
    {

      
    }
    void OnMessageArrived(string msg)
    {

        string[] msgSplit = msg.Split(',');
        Debug.Log("message " + msgSplit);
        Debug.Log("Switch " + msgSplit[0]);
        Debug.Log("Fire" + msgSplit[1]);

        latestMessageSwitch = msgSplit[0].Trim();
        latestMessageFire = msgSplit[1].Trim();


    }


    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }

    // Update is called once per frame
    void Update()
    {
        number = float.Parse(latestMessageFire, CultureInfo.InvariantCulture.NumberFormat);

        fire1.ParticleSystem.startLifetime = number;

        if (latestMessageSwitch == "1")
        {
            fire.SetActive(true);
        }
        if (latestMessageSwitch == "0")
        {
            fire.SetActive(false);
        }
    }
}
