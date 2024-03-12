using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    private const float IncreaseRate = 0.1f;
    public void OnButtonClicked_Bed()
    {
        FeedbackText.Instance.ShowFeedbackText("GOOD MORNINGGG!!");
        UIManager.Instance.UpdateBankBalance(UIManager.Instance.PlayerData.BankBalance * IncreaseRate);
    }
}
