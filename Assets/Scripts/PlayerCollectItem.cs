using UnityEngine;
using System.Collections.Generic;

public class PlayerCollectItem : MonoBehaviour
{
    private List<string> keys = new();


    public void AddKey(string doorKeyCode)
    {
        keys.Add(doorKeyCode);
    }


    public bool CheckKey(string doorCode)
    {
        foreach (string doorKeyCode in keys)
        {
            if (doorKeyCode == doorCode)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        return false;
    }
}
