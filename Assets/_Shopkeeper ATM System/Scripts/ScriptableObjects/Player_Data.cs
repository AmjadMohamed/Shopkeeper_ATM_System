using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New User", menuName = "User")]
public class Player_Data : ScriptableObject
{
    public float CoinBalance;
    public float BankBalance;
}
