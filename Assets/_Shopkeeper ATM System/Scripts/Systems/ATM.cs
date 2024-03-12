using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ATM : MonoBehaviour
{
    [SerializeField] private TMP_InputField amount_InputField;
    [SerializeField] private GameObject atm_Panel;


    public void OnButtonClick_Deposit()
    {
        if (int.TryParse(amount_InputField.text, out int amount))
        {
            if (amount < 0)
            {
                FeedbackText.Instance.ShowFeedbackText("Please, Enter Number > 0");
                return;
            }
            else if (UIManager.Instance.PlayerData.CoinBalance < amount)
            {
                FeedbackText.Instance.ShowFeedbackText("You Don't Have Enough Coins");
                return;
            }
            UIManager.Instance.UpdateCoinBalance(-amount);
            UIManager.Instance.UpdateBankBalance(amount);
        }
    }

    public void OnButtonClick_Withdraw()
    {
        if (int.TryParse(amount_InputField.text, out int amount))
        {
            if (amount < 0)
            {
                FeedbackText.Instance.ShowFeedbackText("Please, Enter Number > 0");
                return;
            }
            else if (UIManager.Instance.PlayerData.BankBalance < amount)
            {
                FeedbackText.Instance.ShowFeedbackText("You Don't Have Enough Balance");
                return;
            }
            UIManager.Instance.UpdateCoinBalance(amount);
            UIManager.Instance.UpdateBankBalance(-amount);
        }
    }

    public void OnButtonClick_OpenATM()
    {
        atm_Panel.SetActive(true);
    }
}

