using UnityEngine;

public class ChangeCubeColorChallenge : MonoBehaviour
{
    [SerializeField] private GameObject cube;

    [SerializeField] private int points;

    private Renderer cubeRenderer;

    [SerializeField] private bool changeColor;

    // Start is called before the first frame update
    private void Start()
    {
        cubeRenderer =  cube.GetComponent<Renderer>();
       cubeRenderer.material.color = Color.red;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            points += 10;
        }

        if (points <= 50 || changeColor) return;
        cubeRenderer.material.color = Color.green;
        changeColor = true;
    }
}
