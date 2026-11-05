using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class RandomChoose : MonoBehaviour
{
    [SerializeField]
    private string[] names;
    
    [SerializeField]
    private int[] ages;

    [SerializeField]
    private string[] cars;

    [SerializeField]
    private InputActionReference randomChooseInput;

    private bool warnedMissingData;

    private void OnEnable()
    {
        if (randomChooseInput == null)
        {
            Debug.LogWarning("RandomChoose has no InputActionReference assigned.");
            return;
        }

        randomChooseInput.action.Enable();
        randomChooseInput.action.performed += OnChoose;
    }

    private void OnDisable()
    {
        if (randomChooseInput == null)
        {
            return;
        }

        randomChooseInput.action.performed -= OnChoose;
        randomChooseInput.action.Disable();
    }

    private void OnChoose(InputAction.CallbackContext ctx)
    {
        var randomIndex = Random.Range(0, names.Length);

        Debug.Log("name:" + names[randomIndex] +", age:" + ages[randomIndex] + ", car:" + cars[randomIndex]);
    }
}
