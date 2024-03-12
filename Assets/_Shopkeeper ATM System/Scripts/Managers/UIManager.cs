using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    [SerializeField] private TMP_Text CoinBalance_Text;
    [SerializeField] private TMP_Text BankBalance_Text;
    [SerializeField] private Player_Data _playerData;

    public static UIManager Instance => instance;
    public Player_Data PlayerData => _playerData;

    private void Awake()
    {
        if (instance && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        CoinBalance_Text.text = $"Coins: <color=yellow>{_playerData.CoinBalance}</color> $";
        BankBalance_Text.text = $"Bank: <color=yellow>{_playerData.BankBalance}</color> $";
    }

    public void UpdateCoinBalance(float amount)
    {
        _playerData.CoinBalance += amount;
        CoinBalance_Text.text = $"Coins: <color=yellow>{_playerData.CoinBalance}</color> $";
    }

    public void UpdateBankBalance(float amount)
    {
        _playerData.BankBalance += amount;
        BankBalance_Text.text = $"Bank: <color=yellow>{_playerData.BankBalance}</color> $";
    }
}
