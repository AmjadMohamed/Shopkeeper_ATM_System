using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TweenPanel : MonoBehaviour
{
    [SerializeField] private float Duration = 0.5f;

    void OnEnable()
    {
        LeanTween.cancel(this.gameObject);
        Vector3 initialScale = new Vector3(0.2f, 0.2f, 0.2f);
        transform.localScale = initialScale;

        LeanTween.scale(this.gameObject, Vector3.one, Duration)
            .setEaseOutBack();
    }

    public void OnButtonClick_ClosePanel()
    {
        LeanTween.cancel(this.gameObject);

        LeanTween.scale(this.gameObject, Vector3.zero, Duration)
            .setEaseInBack().setOnComplete(() => this.gameObject.SetActive(false));
    }
}
