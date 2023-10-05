using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    private const string EnemyNameKey = "EnemyName";

    public string GetName()
    {
        return PlayerPrefs.GetString(EnemyNameKey);
    }

    public void SetName(string name)
    {
        PlayerPrefs.SetString(EnemyNameKey, name);
    }

    public void ResetName()
    {
        PlayerPrefs.SetString(EnemyNameKey, null);
    }
}
