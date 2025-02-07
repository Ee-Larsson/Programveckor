using UnityEngine;

public class newInventoryScript : MonoBehaviour
{
    public static newInventoryScript Instance;  // Singleton instance

    private int itemCount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddItem(int amount)
    {
        itemCount += amount;
        Debug.Log("Items collected: " + itemCount);
    }

    public int GetItemCount()
    {
        return itemCount;
    }
}

