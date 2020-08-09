using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{
    public static event Action OnDinnersReady;

    public static void TriggerDinnersReady()
    {
        Debug.Log("Dinner is ready!");
        OnDinnersReady?.Invoke();
    }
}
