//
// AsyncAssert.cs
//
// Created by Artem Feoktistov <afeoktistov@tango.me>
//
// Copyright (c) 2017 TangoMe, Inc.
// All Rights Reserved.
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using System.Threading.Tasks;
using System;

public delegate Task AsyncTestDelegate();

public static class AsyncAssert
{
    public static T ThrowsAsync<T>(Task asyncMethod) where T : Exception
    {
        //TODO
        //await ThrowsAsync<T>(asyncMethod,"");
        return default(T);
    }

    public static T ThrowsAsync<T>(Task asyncMethod,string message) where T : Exception
    {
        //TODO
        //await ThrowsAsync(typeof(T), asyncMethod, message);
        return default(T);
    }

    public static T ThrowsAsync<T>(AsyncTestDelegate asyncMethod) where T : Exception
    {
        //TODO
        //await asyncTestMethod();
        return default(T);
    }

    public static Exception ThrowsAsync(Type type, AsyncTestDelegate asyncTestMethod)
    {
        //TODO
        //await asyncTestMethod();
        return null;
    }

    public static void DoesNotThrowAsync(AsyncTestDelegate code)
    {
        //TODO
    }

    public static void DoesNotThrowAsync(AsyncTestDelegate code, string message, params object[] parms)
    {
        //TODO
    }

    public static Exception ThrowsAsync(Type type, Task asyncMethod, string message = "")
    {
        return null;
        /*
        try
        {
            asyncMethod; //Should throw..
        }

        catch(T)
        {
            //Ok! Swallow the exception.
            return;
        }
        catch(Exception e)
        {
            if (e.GetType() == type)
            {
                //Ok! Swallow the exception.
                return;
            }
            if(message != "")
            {
                Assert.That(e, Is.TypeOf(type), message + " " + e.ToString()); //of course this fail because it goes through the first catch..
            }
            else
            {
                Assert.That(e, Is.TypeOf(type), e.ToString());
            }
            throw; //probably unreachable
        }
        Assert.Fail("Expected an exception of type " + type.FullName + " but no exception was thrown."  );
        */
    }
}