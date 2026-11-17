using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    [SerializeField] 
    private int points;

    [SerializeField] 
    private bool hasMessage;
    
    // Update is called once per frame
    private void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            points += 10;
        }

        if (points < 50 || hasMessage) return;
        Debug.Log("You are Awesome!!!");
        hasMessage = true;
    }
}
