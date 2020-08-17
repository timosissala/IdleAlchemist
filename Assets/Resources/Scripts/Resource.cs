using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Resource : ScriptableObject
{
    public int amount;

    public int value;

    public void AddResource(int amount)
    {
        this.amount += amount;
    }

    public bool SpendResource(int amount)
    {
        bool result = false;
        if (amount <= this.amount)
        {
            this.amount -= amount;
            result = true;
        }
        return result;
    }

    public int GetSellValue()
    {
        return value;
    }
}