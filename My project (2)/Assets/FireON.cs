using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class FireON : MonoBehaviour
{
    string latestMessage;
    public GameObject fire;
    public float number;
    public ParticleSystem fire1;
    // Start is called before the first frame update
    void Start()
    {

      
    }
    void OnMessageArrived(string msg)
    {
        Debug.Log("Message arrived: " + msg);
        latestMessage = msg.Trim(); //remove new line character at end of string

    }
    // Update is called once per frame
    void Update()
    {
        number = float.Parse(latestMessage, CultureInfo.InvariantCulture.NumberFormat);
        fire1.startLifetime = number;
        if (latestMessage == "1")
        {
            fire.SetActive(false);
        }
        if (latestMessage == "0")
        {
            fire.SetActive(true);
        }

    }
}
