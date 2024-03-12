using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class TweenButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Button _button;
    private Vector3 _originalScale;

    void Start()
    {
        _button = GetComponent<Button>();
        _originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_button.interactable)
        {
            LeanTween.scale(gameObject, _originalScale * 1.2f, 0.2f);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_button.interactable)
        {
            LeanTween.scale(gameObject, _originalScale, 0.2f);
        }
    }
}