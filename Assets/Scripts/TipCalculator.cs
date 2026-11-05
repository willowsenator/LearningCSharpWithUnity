using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    [SerializeField] private float bill;

    [SerializeField] private float tip;
    // Start is called before the first frame update
    private void Start()
    {
        var tipAmount = bill * (tip / 100);
        var totalAmount = bill + tipAmount;
        
        Debug.Log("The bill is: " + bill);
        Debug.Log("The tip amount is: " + tipAmount);
        Debug.Log("So you owe: " + totalAmount);
    }
}
