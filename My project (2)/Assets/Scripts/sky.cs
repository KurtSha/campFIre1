using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;


public class sky : MonoBehaviour
{
    public Material sky1;
    void Start()
    {
        RenderSettings.skybox = sky1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*    void OnMessageArrived(string msg)
    {

        string[] msgSplit = msg.Split(',');
        Debug.Log("message " + msgSplit);
        Debug.Log("Switch " + msgSplit[0]);
        Debug.Log("Fire" + msgSplit[1]);

        latestMessageSwitch = msgSplit[0].Trim();
        latestMessageFire = msgSplit[1].Trim();


    }*/
}
