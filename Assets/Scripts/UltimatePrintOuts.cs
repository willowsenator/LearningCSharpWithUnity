using System.Collections;
using UnityEngine;

public class UltimatePrintOuts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartCoroutine(PrintWays());
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private static IEnumerator PrintWays()
    {
        for (var i = 0; i < 30; i++)
        {
            if (i < 10)
            {
                Debug.Log(i);
            }
            else if (i < 19)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
                
            }
            else
            {
                if (i % 2 != 0)
                {
                    Debug.Log(i);
                }
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
