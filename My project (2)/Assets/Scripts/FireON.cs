using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class FireON : MonoBehaviour
{
    string latestMessageSwitch;
    string latestMessageFire;
    string latestMessageSky;
    public GameObject fire;
    public float number;
    public ParticleSystem fire1;
    public Material skyDay;
    public Material skyNight;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyDay;

    }
    void OnMessageArrived(string msg)
    {

        string[] msgSplit = msg.Split(',');
        Debug.Log("message " + msgSplit);
        Debug.Log("Switch " + msgSplit[0]);
        Debug.Log("Fire" + msgSplit[1]);
        Debug.Log("Sky" + msgSplit[2]);

        latestMessageSwitch = msgSplit[0].Trim();
        latestMessageFire = msgSplit[1].Trim();
        latestMessageSky = msgSplit[2].Trim();


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

        fire1.startSpeed = number;

        if (latestMessageSwitch == "1")
        {
            fire1.startLifetime = 2;
        }
        if (latestMessageSwitch == "0")
        {
            fire1.startLifetime = 0;
        }

        if (latestMessageSky == "1")
        { 
            RenderSettings.skybox = skyDay; 
        }
        if (latestMessageSky == "0")
        {
            RenderSettings.skybox = skyNight;
        }
    }
}
