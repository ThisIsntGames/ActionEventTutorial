using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DwarfTask : MonoBehaviour
{
    [SerializeField] private string dinnerResponse = null;
    [SerializeField] private Text text = null;

    public void GiveDinnerResponse()
    {
        var fullResponse = "Hello, my name is " + gameObject.name + " and " + dinnerResponse;
        text.text = fullResponse;
        Debug.Log(fullResponse);
    }
}
