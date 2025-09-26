using System.Collections;
using UnityEngine;

public class FastSpeedChallenge : MonoBehaviour
{
    
    [SerializeField]
    private int maxSpeed;
    [SerializeField]
    private static int speed = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartCoroutine(IncreaseSpeed());
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    
    private static IEnumerator IncreaseSpeed()
    {
        var maxSpeed = Random.Range(60, 120);
        Debug.Log("Max Speed: " + maxSpeed);
        while (true)
        {
            if (speed >= maxSpeed)
            {
                Debug.Log("Max Speed Reached!");
                yield break;
            }
            speed += 5;
            Debug.Log("Current Speed: " + speed);
            yield return new WaitForSeconds(5f);
        }
    }
}
