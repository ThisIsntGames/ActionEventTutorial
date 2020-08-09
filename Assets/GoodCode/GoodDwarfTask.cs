using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameEvents;

public class GoodDwarfTask : MonoBehaviour
{
    [SerializeField] private string dinnerResponse = null;
    [SerializeField] private Text text = null;
    
    // Start is called before the first frame update
    void Start()
    {
        subscribeToActions();
    }

    private void OnDestroy()
    {
        unSubscribeToAction();
    }

    private void subscribeToActions()
    {
        OnDinnersReady += GiveDinnerResponse;
    }

    private void unSubscribeToAction()
    {
        OnDinnersReady -= GiveDinnerResponse;
    }

    //Same as before but it's private now.
    private void GiveDinnerResponse()
    {
        var fullResponse = "Hello, My name is " + gameObject.name + " and " + dinnerResponse;
        text.text = fullResponse;
        Debug.Log(fullResponse);
    }
    
}
