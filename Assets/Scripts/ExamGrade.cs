using UnityEngine;

public class ExamGrade : MonoBehaviour
{

    [SerializeField] private float[] quizes;

    [SerializeField] 
    private float average;

    private float sum;

    // Start is called before the first frame update
    private void Start()
    {
        foreach(var item in quizes)
        {
            sum += item;
        }

        average = Mathf.Round(sum / quizes.Length);

        switch (average)
        {
            case >= 90:
                Debug.Log("Grade A");
                break;
            case >= 80 and < 90:
                Debug.Log("Grade B");
                break;
            default:
            {
                Debug.Log(average is > 70 and 80 ? "Grade C" : "Grade F");

                break;
            }
        }
    }
}
