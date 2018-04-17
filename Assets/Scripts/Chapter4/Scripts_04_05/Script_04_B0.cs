﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_B0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SendMessageUpwards("ReceiveSendMessage", "B0-----SendMessageUpwards()");
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void ReceiveSendMessage(string str)
    {
        Debug.Log("B0---Receive" + str);
    }

    void ReceiveBroadcastMessage(string str)
    {
        Debug.Log("B0---Receive" + str);
    }

    void ReceiveSendMessageUpwards(string str)
    {
        Debug.Log("B0---Receive" + str);
    }

}
