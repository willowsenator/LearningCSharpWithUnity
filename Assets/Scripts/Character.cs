using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Character : MonoBehaviour
{
    [SerializeField] 
    private int points;

    [SerializeField] 
    private bool hasMessage;
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            points += 10;
        }

        if (points < 50 || hasMessage) return;
        Debug.Log("You are Awesome!!!");
        hasMessage = true;
    }
}
