using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinnersReady : MonoBehaviour
{
    [SerializeField] private GameObject[] dwarves = new GameObject[5];

    private void OnMouseDown()
    {
        Debug.Log("Dinner is ready!");

        for (int i = 0, n = dwarves.Length; i < n; i++)
        {
            var currentTask = dwarves[i].GetComponent<DwarfTask>();
            currentTask.GiveDinnerResponse();
        }
    }
}
