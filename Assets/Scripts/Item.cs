using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private new string name;

    [SerializeField] private string description;

    [SerializeField] private float attackStrength;

    [SerializeField] private Sprite icon;

   private void Start()
   {
        Debug.Log("Name: " + name);
        Debug.Log("Description: " + description);
        Debug.Log("Attack: " + attackStrength);
   }
}