using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class QuizGradeAverage : MonoBehaviour
{
    private const int MaxQuizes = 5;
    [SerializeField] 
    private float[] quizes = new float[MaxQuizes];

    [SerializeField] private float average = 0.0f;

    private void Start()
    {
        float sum = 0;
        for (var i = 0; i < MaxQuizes; i++)
        {
            quizes[i] = Random.Range(0f, 100f);
            sum += quizes[i];
            
            Debug.Log("Quiz" + i + ": " + quizes[i]);
        }
        average = Mathf.Round(sum/MaxQuizes)/1000f;

        Debug.Log("Average: " + average);
        
        if (average >= 90)
        {
            Debug.Log("Grade A");
        }
        else if (average is >= 80 and < 90)
        {
            Debug.Log("Grade B");
        }
        else if (average is > 70 and < 80)
        {
            Debug.Log("Grade C");
        }
        else
        {
            Debug.Log("Grade F");
        }
    }

    
}
