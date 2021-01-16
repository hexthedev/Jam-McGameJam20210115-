﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game Instance = null;

    /// <summary>
    /// -100 for happy and +100 for angry population
    /// </summary>
    public float score;

    public float time = 100;


    public void Awake()
    {
        Instance = this;

    }



    public void Update()
    {
        time -= Time.deltaTime;
        Events.Instance.Invoke(Events.eTimer, time);

        if(time <= 0)
        {
            Events.Instance.Invoke(Events.eGameOver, null);
        }

    }




}
