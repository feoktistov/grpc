//
// Launch.cs
//
// Created by Artem Feoktistov <afeoktistov@tango.me>
//
// Copyright (c) 2017 TangoMe, Inc.
// All Rights Reserved.
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launch : MonoBehaviour
{
    [SerializeField] Text Message;

    void Start()
    {
        GreeterServer.Start();
    }


    public void OnStartClient()
    {
        Message.text = GreeterClient.Start().Message;
    }
}
