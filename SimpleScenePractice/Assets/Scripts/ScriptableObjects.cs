using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = " New Coin", menuName = "Coins")]
public class ScriptableObjects : ScriptableObject
{
    public new string name;
    
    public int coinCost;

}
