using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    private const string Key = "PlayerName";

    public string Get() // TODO: segragate interface.
    {
        return PlayerPrefs.GetString(Key);
    }

    public void Set(string value)
    {
        PlayerPrefs.SetString(Key, value);
    }
}
