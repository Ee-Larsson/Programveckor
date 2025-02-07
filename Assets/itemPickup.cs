using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public int value = 1; // How many items this pickup adds

    private void ontriggerenter2d(Collider2D other)
    {
        if (other.CompareTag("Player")) // Make sure player has "Player" tag
        {
            newInventoryScript.Instance.AddItem(value);
            Destroy(gameObject); // Remove the item from the scene
        }
    }
}



