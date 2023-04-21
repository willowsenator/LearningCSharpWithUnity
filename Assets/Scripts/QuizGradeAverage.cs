using UnityEngine;

public class QuizGradeAverage : MonoBehaviour
{
    private const int MaxQuizes = 5;
    [SerializeField] private float[] quizes = new float[MaxQuizes];

    private void Start()
    {
        float sum = 0;
        for (var i = 0; i < MaxQuizes; i++)
        {
            quizes[i] = Random.Range(0f, 100f);
            sum += quizes[i];
            
            Debug.Log("Quiz" + i + ": " + quizes[i]);
        }

        Debug.Log("Average: " + Mathf.Round(sum/MaxQuizes)/1000f);
    }
}
