using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameUI : MonoBehaviour
{
    public static GameUI instance;

    private void OnEnable()
    {
        instance = this;
    }
}
