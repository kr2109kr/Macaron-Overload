using UnityEngine;
using System.Collections.Generic;

public class PlayerCollectItem : MonoBehaviour
{
    private List<string> keys = new();

    public void AddKey(string doorKeyCode)
    {
        keys.Add(doorKeyCode);
    }
}
