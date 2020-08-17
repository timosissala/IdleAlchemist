using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTimer : MonoBehaviour
{
    public static GlobalTimer instance;

    [SerializeField]
    private GameEvent OnTick;

    private Timer timer;
    [SerializeField]
    public float tickDuration = 1.0f;

    private void Awake()
    {
        instance = this;
        timer = gameObject.AddComponent<Timer>();
        timer.duration = tickDuration;
        timer.StartTimer();
    }

    private void Update()
    {
        if (timer.isFinished)
        {
            OnTick.Raise();
            timer.StartTimer();
        }
    }
}
