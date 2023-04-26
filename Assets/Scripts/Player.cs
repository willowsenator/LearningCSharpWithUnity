using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string myName = "Omar Fernando Moreno";
    [SerializeField] private int myAge = 41;
    [SerializeField] private float mySpeed = 30.6f;
    [SerializeField] private int health = 200;
    [SerializeField] private int score = 50;
    [SerializeField] private bool hasAllKeys;
    [SerializeField] private int ammoCount = 30;

    private void Start()
    {
        Debug.Log("Name: " + myName);
        Debug.Log("Age: " + myAge);
        Debug.Log("Speed: " + mySpeed);
        Debug.Log("Health: " + health);
        Debug.Log("Score: " + score);
        Debug.Log("IsAllKeys: " + hasAllKeys);
        Debug.Log("AmmoCount: " + ammoCount);
    }

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        score += 10;
    }
}

