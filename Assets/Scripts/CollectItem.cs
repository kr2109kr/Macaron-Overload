using UnityEngine;
using System.Collections.Generic;

public class CollectItem : MonoBehaviour
{
    private List<GameObject> items = new();

    private void AddItem(GameObject item)
    {
        items.Add(item);
    }
}
