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

public class Launch : MonoBehaviour
{
  void Start ()
  {
    GreeterServer.Start ();
  }


  public void OnStartClient()
  {
    GreeterClient.Start ();
  }
}
