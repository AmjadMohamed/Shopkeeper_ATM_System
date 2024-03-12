using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FeedbackText : MonoBehaviour
{
    private static FeedbackText instance;

    [SerializeField] private TMP_Text feedbackText;

    public static FeedbackText Instance => instance;

    void Awake()
    {
        if (instance && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void ShowFeedbackText(string message)
    {
        feedbackText.text = message;

        LeanTween.cancel(feedbackText.gameObject);
        LeanTween.moveY(feedbackText.gameObject, 50, 0.5f)
            .setOnComplete(() => LeanTween.moveY(feedbackText.gameObject, -100, 0.5f).setDelay(2.5f));
    }
}
