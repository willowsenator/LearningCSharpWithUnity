using System.Collections;
using UnityEngine;

public class PrintOut : MonoBehaviour
{
    [SerializeField]
    private int apples;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartCoroutine(PrintApples());
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private IEnumerator PrintApples()
    {
        for (var i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(1); // Wait for 1 second between prints
        }
    }
}
