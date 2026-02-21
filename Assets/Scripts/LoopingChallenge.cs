using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cubes;
    
    [SerializeField]
    private InputActionReference inputAction;

    private void OnEnable()
    {
        if (inputAction == null)
        {
            Debug.LogWarning("InputActionReference is not assigned.");
            return;
        }
        
        inputAction.action.performed += OnInputActionPerformed;
        inputAction.action.Enable();
    }

    private void OnDisable()
    {
        if (inputAction == null)
        {
            return;
        }
        
        inputAction.action.performed -= OnInputActionPerformed;
        inputAction.action.Disable();
    }

    private void OnInputActionPerformed(InputAction.CallbackContext ctx)
    {
        // For each cube, change its color to a random color
        /*foreach(var cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }*/
        
        // For i loop
        for(int i=0; i < cubes.Length; i++)
        {
            cubes[i].GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}
